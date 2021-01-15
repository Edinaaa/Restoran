using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Narudzbe
{
    public partial class frmNarudzba : Form
    {
        private APIService service = new APIService("Narudzba");
        private APIService serviceStavke = new APIService("StavkeNarudzbe");
        private APIService serviceKorisnik = new APIService("Korisnik");
        Restoran.Model.Narudzba narudzba = null;
        Restoran.Model.Korisnik kupac = null;
        int? _id = null;
        List<StavkeNarudzbe> stavkeNarudzbe;
        BindingSource bs;
        public frmNarudzba(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async Task SetStavke() {
            StavkeNarudzbeSearchRequest request = new StavkeNarudzbeSearchRequest() { NaruszbaId = _id };
            var stavke = await serviceStavke.Get<List<Restoran.Model.StavkaNarudzbe>>(request);
            stavkeNarudzbe = new List<StavkeNarudzbe>();
            foreach (var item in stavke)
            {
                StavkeNarudzbe s = new StavkeNarudzbe();
                if (item.StavkeMeniaId == null)
                {
                    s.Naziv = item.Kombinacija.Naziv;
                    s.Slika = item.Kombinacija.Slika;
                }
                else
                {

                    s.Naziv = item.StavkeMenia.Artikal.Naziv;
                    s.Slika = item.StavkeMenia.Artikal.Slika;
                }
                s.Kolicina = item.Kolicina;
                s.Pdv = item.Pdv;
                s.StavkaNarudzbeId = item.StavkaNarudzbeId;
                s.Cijena = item.Cijena;
                s.CijenaSaPdv = item.CijenaSaPdv;
                s.NarudzbaId = item.NarudzbaId;
                stavkeNarudzbe.Add(s);
            }
           
        }
    
        private async void frmNarudzba_Load(object sender, EventArgs e)
        {
            narudzba = await service.GetById<Restoran.Model.Narudzba>(_id);
            if (narudzba!=null)
            {
                kupac = await serviceKorisnik.GetById<Restoran.Model.Korisnik>(narudzba.KorisnikId);

            }

           await SetStavke();
            dtpDatumNarudzbe.Value = narudzba.DatumNarudzbe;
            txtBrojStola.Text = narudzba.BrojStola.ToString();
            txtCijena.Text = narudzba.Cijena.ToString();
            txtCijenaSaPdv.Text = narudzba.CijenaSaPdv.ToString();
            txtPDV.Text = narudzba.Pdv.ToString();
            if (kupac!=null)
            {
                txtKupac.Text = kupac.KorisnickoIme;

            }
            else
            {
                txtKupac.Text ="Kupac";

            }
            dgvStavkeNarudzbe.AutoGenerateColumns = false;
            bs = new BindingSource();
            bs.DataSource = stavkeNarudzbe;
            dgvStavkeNarudzbe.DataSource = bs;
            bs.ResetBindings(false);
            cbNaplaceno.Checked = narudzba.Naplaceno;
            cbNaplataKreditima.Checked = narudzba.PlacanjeKreditima;
            cbOdobri.Checked = narudzba.Odobrena;
            cbOdbij.Checked = narudzba.Odbijena;
            if (narudzba.Odbijena || narudzba.Odobrena)
            {
                cbOdbij.Enabled = false;
                cbOdobri.Enabled = false;
            }


        }

        private async void btnNaplati_Click(object sender, EventArgs e)
        {
            if (cbOdobri.Checked && !cbNaplaceno.Checked)//konobar moze da naplati iako kupac nije cekirao da zeli naplatu
            {                   //(npr. kupac je zaboravio da to cekira)
                                 //ali ne moze da naplati ne odobrenu narudzbu
                if (cbNaplataKreditima.Checked && kupac!=null)
                    {
                        double iznos = double.Parse( txtCijenaSaPdv.Text.ToString());
                        if (iznos>kupac.IznosKredita)
                        {
                       DialogResult response=  MessageBox.Show("Nema dovoljno sredstava. Da li zelite naplatiti gotovinom?", "Naplacivanje kreditima", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (response.Equals(DialogResult.No))
                            {
                                Close();
                            }
                        }
                        else
                        {
                            KorisniciUpsertReqests k = new KorisniciUpsertReqests()
                            {
                                KorisnickoIme = kupac.KorisnickoIme,
                                Ime = kupac.Ime,
                                Prezime = kupac.Prezime,
                                IznosKredita = -iznos,
                                Spol = kupac.Spol,
                                DatumRodenja = kupac.DatumRodenja,
                                DatumZaposljavanja = kupac.DatumZaposljavanja,


                            };
                            var korisnik = await serviceKorisnik.Update<Restoran.Model.Korisnik>(kupac.KorisnikId, k);

                        }


                    }
     
                NarudzbaUpsertRequest r = new NarudzbaUpsertRequest() { 
                    Naplaceno = true 
                  };
                   var n=  await service.Update<Restoran.Model.Narudzba>(narudzba.NarudzbaId, r);
                cbNaplaceno.Checked = n.Naplaceno;
            }
            else
            {
                MessageBox.Show("Narudzba ne moze biti naplacena ako nije odobrena ili ako je predhodno naplacena.", "Narudzba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private async void cbOdbij_Click(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest r = new NarudzbaUpsertRequest()
            {
                Odbijena = true,
                Odobrena = false
            };
            var n = await service.Update<Restoran.Model.Narudzba>(narudzba.NarudzbaId, r);
            if (n != null && n.Odbijena)
            {
                cbOdbij.Checked = n.Odbijena;
                cbOdobri.Checked = n.Odobrena;
                MessageBox.Show("Uspjesna izmjenjena narudzba", "Narudzba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void cbOdobri_Click(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest r = new NarudzbaUpsertRequest()
            {
                Odbijena = false,
                Odobrena = true
            };
            var n = await service.Update<Restoran.Model.Narudzba>(narudzba.NarudzbaId, r);
            if (n != null && n.Odobrena)
            {
                cbOdbij.Checked = n.Odbijena;
                cbOdobri.Checked = n.Odobrena;
                MessageBox.Show("Uspjesni izmjenjena narudzba", "Narudzba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
