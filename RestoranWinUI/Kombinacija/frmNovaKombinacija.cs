using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Artikli;
using RestoranWinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Kombinacija
{
    public partial class frmNovaKombinacija : Form
    {
        private APIService serviceKombinacija = new APIService("Kombinacija");
        private APIService serviceKombinacijaStavke = new APIService("StavkeKombinacije");
        private APIService serviceArtikal = new APIService("Artikal");


        KombinacijaUpsertRequest kombinacija;

        public List<StavkeKombinacijeVm> stavkes { get; set; }
        public int? kombinacijaId { get; set; }

        public string Opcija { get; set; }// ako je opcija update/ponisti u dgv na frm ponuda ce dodati kombinaciju/ ukloniti
        public string GetOpcija (){ return Opcija; }

        public frmNovaKombinacija(int ponudaid, int? kombinacijaid=null)
        {
            InitializeComponent();
            
            kombinacija = new KombinacijaUpsertRequest();
            kombinacija.PonudaId = ponudaid;
            kombinacijaId = kombinacijaid;
            kombinacija.Stavke = new List<StavkeKombinacije>();
            stavkes = new List<StavkeKombinacijeVm>();

        }
        private async Task SetStavke() {
            StavkeKombinacijeSearchRequest request = new StavkeKombinacijeSearchRequest() { KombinacijaId = (int)kombinacijaId };
            var sk = await serviceKombinacijaStavke.Get<List<Restoran.Model.StavkeKombinacije>>(request);
            foreach (var item in sk)
            {
                stavkes.Add(new StavkeKombinacijeVm()
                {
                    Artikal = item.Artikal,
                    ArtikalId = item.ArtikalId,
                    Kolicina = item.Kolicina,
                    KombinacijaId = item.KombinacijaId,
                    Naziv = item.Artikal.Naziv,
                    Slika = item.Artikal.Slika,
                    Cijena = item.Artikal.Cijena,
                    PDV = item.Artikal.PDV,
                    CijenaSaPdv = item.Artikal.CijenaSaPdv,
                    StavkeKombinacijeId = item.StavkeKombinacijeId

                });
            }
        }
        private async Task SetKombinacija() {
            if (kombinacijaId!=null)
            {
                var k = await serviceKombinacija.GetById<Restoran.Model.Kombinacija>(kombinacijaId);
                kombinacija.PonudaId = k.PonudaId;
                kombinacija.Naziv = k.Naziv;
                kombinacija.PDV = k.PDV;
                kombinacija.Slika = k.Slika;
                kombinacija.Cijena = k.Cijena;
                kombinacija.CijenaSaPdv = k.CijenaSaPdv;
            }
            else
            {
              //  kombinacija.PonudaId se setuje u konstruktoru
                kombinacija.Naziv =txtNaziv.Text.ToString();
              
                kombinacija.PDV =int.Parse( txtPdv.Text.ToString());
              //  kombinacija.Slika se setuje u metodi dodaj sliku
                kombinacija.Cijena = double.Parse( txtCijena.Text.ToString());
                double pdv =( kombinacija.PDV * kombinacija.Cijena)/ 100 ;
                kombinacija.CijenaSaPdv = kombinacija.Cijena + pdv;
                List<StavkeKombinacije> stavkeKombinacije = new List<StavkeKombinacije>();
                foreach (var item in stavkes)
                {
                    stavkeKombinacije.Add(new StavkeKombinacije()
                    {
                        ArtikalId = item.ArtikalId,
                        Kolicina = item.Kolicina
                    });
                }
                kombinacija.Stavke = stavkeKombinacije;
            }
           

        }
        private async void frmNovaKombinacija_Load(object sender, EventArgs e)
        {
            if (kombinacijaId!=null)
            {
               await SetKombinacija();
                await SetStavke();
                RefreshControls();

            }
            txtPdv.Text = "17";
        }
        private void RefreshControls()
        {
            txtCijena.Text = kombinacija.Cijena.ToString();
            txtCijenaSaPdv.Text = kombinacija.CijenaSaPdv.ToString();
            txtNaziv.Text = kombinacija.Naziv;
            txtPdv.Text = kombinacija.PDV.ToString();
            pbSlika.Image = Global.ByteToImage(kombinacija.Slika);
            dgvArtikli.AutoGenerateColumns = false;
           // dgvArtikli.DataSource =stavkes;
            BindingSource bs = new BindingSource();
            bs.DataSource = stavkes;
            dgvArtikli.DataSource = bs;
            bs.ResetBindings(false);
        }
        private async void AddStavka(int id)
        {
            var a = await serviceArtikal.GetById<Restoran.Model.Artikal>(id);
            float Kolicina = 0;
            frmStavkaKombinacije frm = new frmStavkaKombinacije(a);
            frm.ShowDialog();
            Kolicina = frm.GetKolicina();
            if (frm.GetSnimiIzmjene())
            {
                stavkes.Add(new StavkeKombinacijeVm()
                {
                    Artikal = a,
                    ArtikalId = a.ArtikalId,
                    Kolicina = Kolicina,
                    KombinacijaId =0,///ako kombinacija jos nije kreirana 
                    Naziv = a.Naziv,
                    Slika = a.Slika,
                    Cijena = a.Cijena,
                    PDV = a.PDV,
                    CijenaSaPdv = a.CijenaSaPdv,
                    StavkeKombinacijeId = 0

                }); 
            }
           
            frm.Close();
          
            RefreshControls();
        }

        private async void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            await SetKombinacija();
            frmPretragaArtikala frm = new frmPretragaArtikala();
                Global.Lokacija(frm);
                frm.MdiParent = this.MdiParent;
                frm.ShowDialog();
                int id = frm.SendData();
                frm.Close();
                if (id != 0)
                {
                    AddStavka(frm.SendData());

                }


        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                await SetKombinacija();
                Opcija = Global.Update;
                if (kombinacijaId == null)
                {
                    var k = await serviceKombinacija.Insert<Restoran.Model.Kombinacija>(kombinacija);
                    Hide();

                }
                else
                {
                    var k = await serviceKombinacija.Update<Restoran.Model.Kombinacija>((int)kombinacijaId, kombinacija);
                    Hide();

                }
            }
           

        }

        private void dgvArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           var aid=int.Parse( dgvArtikli.Rows[e.RowIndex].Cells[0].Value.ToString());
            Artikal a = new Artikal();
            foreach (var item in stavkes)
            {
                if (item.ArtikalId==aid)
                {
                    a = item.Artikal;
                    break;
                }
            }
            float Kolicina = 0;
            frmStavkaKombinacije frm = new frmStavkaKombinacije(a);
            frm.ShowDialog();
            Kolicina = frm.GetKolicina();
            bool izmjena = frm.GetSnimiIzmjene();
            frm.Close();
            for (int i = 0; i < stavkes.Count; i++)
            {
                if (stavkes[i].ArtikalId == a.ArtikalId && izmjena)
                {
                    stavkes[i].Kolicina = Kolicina;
                    break;
                }
                else if (stavkes[i].ArtikalId == a.ArtikalId && !izmjena)
                {
                    stavkes.Remove(stavkes[i]);
                    break;
                }
            }

            RefreshControls();




        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            Opcija = Global.Ponisti;
            Hide();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            kombinacija.Slika= Global.SetSlika(ref openFileDialog2, ref txtSlika,kombinacija.Slika, ref pbSlika);
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (kombinacijaId==null)
            {
                Global.ValidatingObaveznoPolje(ref txtSlika,e, errorProvider);
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtNaziv, e, errorProvider);
        }



        private void dgvArtikli_Validating(object sender, CancelEventArgs e)
        {
              Global.ValidatingObaveznoPoljeDataGridView(ref dgvArtikli, dgvArtikli.Rows.Count < 1, e, errorProvider);

          
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (Global.ValidatingObaveznoPoljeBool(ref txtCijena, e, errorProvider))
            {
                Global.ValidatingDvaDecimalnaPolja(ref txtCijena, e, errorProvider);

            }

        }

   
        private void txtPdv_Validating(object sender, CancelEventArgs e)
        {
            if (Global.ValidatingObaveznoPoljeBool(ref txtPdv, e, errorProvider))
            {
                Global.ValidatingDvaDecimalnaPolja(ref txtPdv, e, errorProvider);

            }
        }
    }
}
