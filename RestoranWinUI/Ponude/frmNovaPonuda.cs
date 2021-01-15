using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Helper;
using RestoranWinUI.Kombinacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Ponude
{
    public partial class frmNovaPonuda : Form
    {
        private APIService service = new APIService("Ponuda");
        private APIService serviceKorisnik = new APIService("Korisnik");

        private APIService serviceKombinacija = new APIService("Kombinacija");
        PonudaUpsertRequest ponuda;
        public Korisnik konobar=new Korisnik();
        public int? PonudaID { get; set; }
        public List<Restoran.Model.Kombinacija> kombinacijas { get; set; }
       private BindingSource bs = new BindingSource();
        private void refreshData()
        {
            bs.ResetBindings(false);
        }
        public frmNovaPonuda(int? id = null)
        {
            InitializeComponent();
            PonudaID = id;
            kombinacijas = new List<Restoran.Model.Kombinacija>();

        }

        private async void frmNovaPonuda_Load(object sender, EventArgs e)
        {
            konobar = await serviceKorisnik.GetById<Restoran.Model.Korisnik>(Global.KorisnikId);

          await  SetPonuda();
            RefreshControls();
        }
        private async void SetKombinacija() {
            if (PonudaID!=null)
            {
                KombinacijaSearchRequest request = new KombinacijaSearchRequest() { PonudaId = (int)PonudaID };
                kombinacijas = await serviceKombinacija.Get<List<Restoran.Model.Kombinacija>>(request);

                bs.DataSource = kombinacijas;
                dgvKombinacije.DataSource = bs;
                bs.ResetBindings(false);
            }
           
        }
        private async Task SetPonuda() {
            if (ponuda==null)
            {
                if (PonudaID == null)
                {
                    ponuda = new PonudaUpsertRequest();
                    ponuda.DatumPocetka = DateTime.Now;
                    ponuda.DatumZavrsetka = DateTime.Now;
                    ponuda.KorisnikId = Global.KorisnikId;
                    ponuda.Kombinacije = new List<int>();

                }
                else
                {
                    var p = await service.GetById<Restoran.Model.Ponuda>(PonudaID);
                    ponuda = new PonudaUpsertRequest();

                    ponuda.DatumPocetka = p.DatumPocetka;
                    ponuda.DatumZavrsetka = p.DatumZavrsetka;
                    ponuda.KorisnikId = p.KorisnikId;
                  
                    SetKombinacija();
                }
            }
            else
            {
                ponuda.DatumPocetka = dtpDatumPocetka.Value;
                ponuda.DatumZavrsetka = dtpDatumZavrsetka.Value;
                
                SetKombinacija();
            }

        
           
        }
        private void RefreshControls() {
          
                dtpDatumPocetka.Value = ponuda.DatumPocetka;
                dtpDatumZavrsetka.Value = ponuda.DatumZavrsetka;
            if (konobar!=null)
            {
                txtKonobar.Text = konobar.Ime + " " + konobar.Prezime;

            }

            dgvKombinacije.AutoGenerateColumns = false;
            //   dgvKombinacije.DataSource = kombinacijas;
            refreshData();
        }

        private void dgvKombinacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        var kombinacijaid=  int.Parse(dgvKombinacije.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmNovaKombinacija frm = new frmNovaKombinacija((int)PonudaID,kombinacijaid);
            Global.Lokacija(frm);
            frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
            if (frm.Opcija == Global.Update)
            {
                SetKombinacija();
            }
            else if (frm.Opcija==Global.Ponisti)
            {
                for (int i = 0; i < kombinacijas.Count; i++)
                {
                    if (kombinacijaid==kombinacijas[i].KombinacijaId)
                    {
                        kombinacijas.Remove(kombinacijas[i]);
                        break;
                    }
                }
            }
            RefreshControls();
            frm.Close();
        }

        private async void btnDodajKombinaciju_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {

                if (PonudaID == null)
                {
                    await SetPonuda();
                    var p = await service.Insert<Restoran.Model.Ponuda>(ponuda);

                    if (p != null)
                    {
                        PonudaID = p.PonudaId;
                        MessageBox.Show("Uspjesno dodana ponuda.", "Ponuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                if (PonudaID != null)
                {
                    frmNovaKombinacija frm = new frmNovaKombinacija((int)PonudaID);
                    Global.Lokacija(frm);
                    frm.ShowDialog();
                    if (frm.Opcija == Global.Update)
                    {
                        SetKombinacija();
                        RefreshControls();
                    }
                    frm.Close();
                }
             
            }
         
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                await SetPonuda();
                ponuda.Kombinacije = new List<int>();
                foreach (var item in kombinacijas)
                {
                    ponuda.Kombinacije.Add(item.KombinacijaId);
                }
                if (PonudaID == null)
                {
                    var p = await service.Insert<Restoran.Model.Ponuda>(ponuda);
                  
                    if (p != null)
                    {
                        PonudaID = p.PonudaId;
                        MessageBox.Show("Uspjesno dodana ponuda.", "Ponuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    var p = await service.Update<Restoran.Model.Ponuda>((int)PonudaID, ponuda);
                    if (p != null)
                    {
                        MessageBox.Show("Uspjesno izmjenjena ponuda.", "Ponuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
               
            Close();
            }
          
        }

        private void dtpDatumPocetka_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingDatumManjiOdTrenutnog(ref dtpDatumPocetka,"Datum pocetka ne moze biti manji od trenutnog.",e,errorProvider );
        }

        private void dtpDatumZavrsetka_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingDatumVeci(dtpDatumPocetka.Value, ref dtpDatumZavrsetka,"Datum zavrsetka ne moze biti manji od datuma pocetka.",e,errorProvider);
        }
    }
}
