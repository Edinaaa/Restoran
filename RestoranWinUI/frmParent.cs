using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Artikli;
using RestoranWinUI.Helper;
using RestoranWinUI.Korisnici;
using RestoranWinUI.Meni;
using RestoranWinUI.Narudzbe;
using RestoranWinUI.Ponude;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI
{
    public partial class frmParent : Form
    {
        private int childFormNumber = 0;
        APIService service = new APIService("Korisnik");
        APIService serviceZahtjevi = new APIService("StavkeZahtjeva");
        List<StavkeZahtjeva> stavkeZahtjeva = null;
        public Korisnik korisnik { get; set; } = null;
        public frmParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void korisniciDetaljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaKorisnika frm = new frmPretragaKorisnika(Global.Update);
            Global.Lokacija(frm);
        
            frm.Show();
         
        }
   

        private void narudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNarudzbe frm = new frmNarudzbe();
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviArtikalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviArtikal frm = new frmNoviArtikal();
           Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private async void RefreshControls()
        {
          
            if (stavkeZahtjeva != null)
            {
                var zahtjeviLIsta = clbNotifikacije.CheckedItems.Cast<Restoran.Model.Zahtjev>().Select(x => x.ZahtjevId).ToList();
              
                foreach (var item in stavkeZahtjeva)
                         {
                             foreach (var i in zahtjeviLIsta)
                             {
                                 if (item.ZahtjevId == i)
                                 {
                                      StavkeZahtjevaUpsertRequest request = new StavkeZahtjevaUpsertRequest() { ZahtjevObradjen = true };

                                      var sz = await serviceZahtjevi.Update<Restoran.Model.StavkeZahtjeva>(item.StavkeZahtjevaId, request);
                                 }
                             }

                         }

            }
            StavkeZahtjevaSerachRequest r = new StavkeZahtjevaSerachRequest() { Obradjeni = false };
            stavkeZahtjeva = await serviceZahtjevi.Get<List<Restoran.Model.StavkeZahtjeva>>(r);
            var zahtjevi = new List<Zahtjev>();
            foreach (var item in stavkeZahtjeva)
            {
                zahtjevi.Add(item.Zahtjev);
            }
            clbNotifikacije.DataSource = zahtjevi;
            clbNotifikacije.DisplayMember = "Naziv";

            txtDatum.Text = DateTime.Now.ToString("dd.MM.yyyy.");
            txtSmjena.Text = DateTime.Now.Hour < 15 ? "Prva" : "Druga";
          korisnik = await service.GetById<Restoran.Model.Korisnik>(Global.KorisnikId);
                txtImePrezime.Text = korisnik.Ime + " " + korisnik.Prezime;
                if (korisnik.Slika.Length != 0)
                {
                    pbxSlika.Image = Global.ByteToImage(korisnik.Slika);

                }
         
         
        }

        private  void frmParent_Load(object sender, EventArgs e)
        {
            RefreshControls();
        }
  
        private void btnOpcije_Click(object sender, EventArgs e)
        {
            if (korisnik!=null)
            {
                frmKorisnik frm = new frmKorisnik(korisnik.KorisnikId);
                Global.Lokacija(frm);
                frm.ShowDialog();

                if (frm.Opcija.Equals(Global.Update))
                {
                    frmLogin frml = new frmLogin();
                    frml.Show();
                    Close();
                }
                
            }

          
        }
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            APIService.password = "";
            APIService.username = "";
    
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
        }

        private void kreditiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKrediti frm = new frmKrediti();
            frm.Show();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaArtikala frm = new frmPretragaArtikala(Global.Update);
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviMeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviMeni frm = new frmNoviMeni();
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaMeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaMenia frm = new frmPretragaMenia(Global.Update);
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaPonuda frm = new frmNovaPonuda();
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaPonuda frm = new frmPretragaPonuda();
            Global.Lokacija(frm);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
