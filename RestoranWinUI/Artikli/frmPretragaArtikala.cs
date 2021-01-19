using Restoran.Model.Request;
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

namespace RestoranWinUI.Artikli
{
    public partial class frmPretragaArtikala : Form
    {
        APIService service = new APIService("Artikal");
        APIService serviceKategorije = new APIService("Kategorija");
        private string _pretraga { get; set; }
        private int idArtikla { get; set; }
        public frmPretragaArtikala(string pretraga="")
        {
            InitializeComponent();
            _pretraga = pretraga;
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            ArtikalSearchRequest searchRequest = new ArtikalSearchRequest() {Naziv=txtNaziv.Text.ToString()};
            var objK = cbxKategorije.SelectedValue;
            if (int.TryParse(objK.ToString(), out int k))
            {
                searchRequest.KategorijaId = k;
            }
            searchRequest.NajProdavaniji = cbNajProdavaniji.Checked;
            var list=  await service.Get<List<Restoran.Model.Artikal>>(searchRequest);
            dgvArtikli.AutoGenerateColumns = false;
            dgvArtikli.DataSource = list;

        }

        private async void frmPretragaArtikala_Load(object sender, EventArgs e)
        {
            var kategorije = await serviceKategorije.Get<List<Restoran.Model.Kategorija>>(null);
            cbxKategorije.DataSource = kategorije;
            cbxKategorije.DisplayMember = "Naziv";
            cbxKategorije.ValueMember = "KategorijaId";
        }

        private void dgvArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idArtikla = int.Parse(dgvArtikli.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (_pretraga.Equals(Global.Update))
            {
                frmNoviArtikal frm = new frmNoviArtikal(idArtikla);
                Global.Lokacija(frm);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            Hide();
          
        }
        public int SendData() { return idArtikla; }
    }
}
