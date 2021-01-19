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

namespace RestoranWinUI.Ponude
{
   
    public partial class frmPretragaPonuda : Form
    {
        private APIService service = new APIService("Ponuda");
        private APIService serviceKorisnik = new APIService("Korisnik");

        PonudaSearchRequest request = new PonudaSearchRequest();
        List<PonudaVm> ponude = new List<PonudaVm>();
        private BindingSource bs = new BindingSource();
        private void refreshData()
        {
            bs.ResetBindings(false);
        }
        public frmPretragaPonuda()
        {
            InitializeComponent();
        }

        private async void frmPretragaPonuda_Load(object sender, EventArgs e)
        {
            KorisniciSeachRequest request = new KorisniciSeachRequest() { Uloga="Konobar"  };
            var k = await serviceKorisnik.Get<List<Restoran.Model.Korisnik>>(request);
            k.Insert(0, new Restoran.Model.Korisnik() { KorisnikId=0, KorisnickoIme="Odaberite korisnika"});
            cbxKorisnik.DataSource =k;
            cbxKorisnik.DisplayMember = "KorisnickoIme";
            cbxKorisnik.ValueMember = "KorisnikId";
            cbxKorisnik.SelectedIndex = 0;
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var objk = cbxKorisnik.SelectedValue;
            if (int.TryParse(objk.ToString(), out int K))
            {
                request.KorisnikId = K;
             //   request.KorisnikId = 1;
            }
           request.DatumPocetka = dtpDatumPocetka.Checked != true ? "" : dtpDatumPocetka.Value.ToString();
            var p = await service.Get<List<Restoran.Model.Ponuda>>(request);
            ponude.Clear();
            foreach (var item in p)
            {
                ponude.Add(new PonudaVm() { 
                KorisnickoIme=item.Korisnik.KorisnickoIme,
                DatumPocetka=item.DatumPocetka,
                DatumZavrsetka=item.DatumZavrsetka,
                PonudaId=item.PonudaId
                
                });
            }
            dgvPonude.AutoGenerateColumns = false;
            bs.DataSource = ponude;
            dgvPonude.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void dgvPonude_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          var PonudaId=int.Parse(  dgvPonude.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmNovaPonuda frm = new frmNovaPonuda(PonudaId);
            frm.Show();
        }
    }
}
