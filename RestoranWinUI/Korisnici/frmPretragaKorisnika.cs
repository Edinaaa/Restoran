using Restoran.Model;
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

namespace RestoranWinUI.Korisnici
{
    public partial class frmPretragaKorisnika : Form
    {
        APIService service = new APIService("Korisnik");
        private int _id { get; set; }
        private string _pretraga { get; set; }
        public frmPretragaKorisnika( string pretraga="")
        {
            InitializeComponent();
            _pretraga = pretraga;
        }
        public int SendData() {
            return _id;
        }

        private async void btnPretrazi_ClickAsync(object sender, EventArgs e)
        {
            KorisniciSeachRequest request = new KorisniciSeachRequest() {
                Ime = txtPretraga.Text,
                Prezime=txtPretraga.Text,
                KorisnickoIme= txtPretraga.Text,
                NajCasci=cbNajcesci.Checked

            };
          var lista=  await service.Get<List< Restoran.Model.Korisnik>>(request);
            dgvKorisnici.AutoGenerateColumns = false;

            dgvKorisnici.DataSource = lista;
        }

    
        private void dgvKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            _id = int.Parse( dgvKorisnici.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (_pretraga.Equals(Global.Update) )
            {
                frmKorisnik frm = new frmKorisnik(_id);
            
                frm.Show();
            }
            Hide();

        }
    }
}
