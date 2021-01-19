using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Artikli;
using RestoranWinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Meni
{
    public partial class frmNoviMeni : Form
    {
        private APIService service = new APIService("Korisnik");
        private APIService serviceMeni = new APIService("Meni");
        private APIService serviceStavkeMenia = new APIService("StavkeMenija");

        private APIService serviceArtikal = new APIService("Artikal");
        BindingSource bs = new BindingSource();
        public List< StavkeMenijaVM> stavke { get; set; }
        public List<StavkeMenija> stavkeMenija { get; set; }

        public int? MeniID { get; set; }
        MeniUpsertRequest request = new MeniUpsertRequest();
        public frmNoviMeni(int? id=null)
        {
            InitializeComponent();
            MeniID = id;
        }
        private void RefreshDataGrtidView() { bs.ResetBindings(false); }
        private  void frmNoviMeni_Load(object sender, EventArgs e)
        {
            RefreshKontrole();
            stavke = new List<StavkeMenijaVM>();
            stavkeMenija = new List<StavkeMenija>();

        }

        public async void RefreshKontrole()
        {
            if (MeniID!=null)
            {
               var m=  await serviceMeni.GetById<Restoran.Model.Meni>(MeniID);
                dtpDatumObjave.Value = m.DatumObjave;
                cbxVazevi.Checked=m.Vazeci;
                txtBNaziv.Text = m.Naziv;
                if (stavke.Count()==0)
                {
                    StavkeMenijaSearchRequest req = new StavkeMenijaSearchRequest() { MeniId = m.MeniId };
                    stavkeMenija = await serviceStavkeMenia.Get<List<Restoran.Model.StavkeMenija>>(req);

                    foreach (var item in stavkeMenija)
                    {
                        stavke.Add(new StavkeMenijaVM()
                        {

                            StavkeMenijaId = item.StavkeMenijaId,
                            ArtikalId = item.ArtikalId,
                            Naziv = item.Artikal.Naziv,
                            Slika = item.Artikal.Slika,
                            Cijena = item.Cijena,
                            CijenaSaPDV = item.CijenaSaPDV,
                            Kategorija = item.Kategorija.Naziv,
                            MeniId = item.MeniId,
                            Popust = item.Popust,
                            Aktivan=item.Aktivan
                        });
                    }
                }
            
            }
            else
            {
                dtpDatumObjave.Value = DateTime.Now;
            }
            var konobar = await service.GetById<Restoran.Model.Korisnik>(Global.KorisnikId);
            txtKonobar.Text = konobar.Ime + " " + konobar.Prezime;

            dgvStavke.AutoGenerateColumns = false;
            if (stavke!=null)
            {
               
                bs.DataSource = stavke;
                dgvStavke.DataSource = bs;
                RefreshDataGrtidView();

            }
        }

        private async void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            frmPretragaArtikala frm = new frmPretragaArtikala();
            Global.Lokacija(frm);
          
            frm.ShowDialog();
            var artikal = await serviceArtikal.GetById<Restoran.Model.Artikal>(frm.SendData());
            frm.Close();
            if (artikal!=null)
            {

                StavkeMenija s = new StavkeMenija()
                {
                    StavkeMenijaId = 0,
                    ArtikalId = artikal.ArtikalId,
                    Artikal = artikal,
                    Cijena = artikal.Cijena,
                    CijenaSaPDV = artikal.CijenaSaPdv,
                    Kategorija = artikal.Kategorija,
                    KategorijaId = artikal.KategorijaId,
                    PDV = artikal.PDV,
                    MeniId = 0,
                    Popust = artikal.Popust,
                    Aktivan=true
                        
                    };
                    stavkeMenija.Add(s);
                StavkeMenijaVM sm = new StavkeMenijaVM()
                {
                    StavkeMenijaId = 0,
                    ArtikalId = artikal.ArtikalId,
                    Naziv = artikal.Naziv,
                    Slika = artikal.Slika,
                    Cijena = artikal.Cijena,
                    CijenaSaPDV = artikal.CijenaSaPdv,
                    Kategorija = artikal.Kategorija.Naziv,
                    MeniId = 0,
                    PDV = artikal.PDV,
                    Popust = artikal.Popust,
                    Aktivan = true
                        
                    };
                    stavke.Add(sm);
                    RefreshKontrole();
               
            }
          
           
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
             

                request.Vazeci = cbxVazevi.Checked;
                request.Naziv = txtBNaziv.Text.ToString();
                request.KorisnikId = Global.KorisnikId;
                request.Stavke = stavkeMenija;

                if (MeniID != null)
                {
                    var m = await serviceMeni.Update<Restoran.Model.Meni>(MeniID, request);
                    if (m != null)
                    {
                        MessageBox.Show("Uspjesno izmjenili meni.", "Meni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var m = await serviceMeni.Insert<Restoran.Model.Meni>(request);
                    if (m != null)
                    {
                        MessageBox.Show("Uspjesno dodan meni.", "Meni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

        }

        private void dgvStavke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var artikalId = int.Parse(dgvStavke.Rows[e.RowIndex].Cells[0].Value.ToString());
            var stavka= stavke.Where(x=>x.ArtikalId==artikalId).FirstOrDefault(); 
            frmStavkeMenia frmstavka = new frmStavkeMenia(stavka);
            Global.Lokacija(frmstavka);
            frmstavka.ShowDialog();
            if (frmstavka.Opcija == Global.Update)
            {
               var s= frmstavka.Stavka;
                stavke.Remove(stavka);
                stavke.Add(s);
                var sm = stavkeMenija.Where(x=>x.ArtikalId==s.ArtikalId).FirstOrDefault();
                stavkeMenija.Remove(sm);
                sm.Cijena = s.Cijena;
                sm.CijenaSaPDV = s.CijenaSaPDV;
                sm.Popust = s.Popust;
                sm.PDV = s.PDV;
                sm.Aktivan = s.Aktivan;
                stavkeMenija.Add(sm);
            
                RefreshKontrole();
            }
       
            frmstavka.Close();
            RefreshDataGrtidView();
        }

        private void txtBNaziv_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtBNaziv, e, errorProvider);
        }

        private void dgvStavke_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPoljeDataGridView(ref dgvStavke, dgvStavke.Rows.Count<1,e, errorProvider);
        }
    }
}
