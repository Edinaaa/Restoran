using Restoran.Model.Request;
using RestoranWinUI.Helper;
using RestoranWinUI.Korisnici;
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
    public partial class frmLogin : Form
    {
         APIService service = new APIService("Korisnik");
        public bool PonovnoLogiranje { get; set; }
        public frmLogin(bool ponovnologiranje=false)
        {
            PonovnoLogiranje = ponovnologiranje;
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

           
          
            try
            {
               
                APIService.username = txtKorisnickoIme.Text;
              APIService.password = txtPassword.Text;
                await service.Get<dynamic>(null);
               
                KorisniciSeachRequest r = new KorisniciSeachRequest() { KorisnickoIme = txtKorisnickoIme.Text };
                var k = await service.Get<List<Restoran.Model.Korisnik>>(r);
                Global.KorisnikId = k[0].KorisnikId;
               
                    frmParent frm = new frmParent();
             
                frm.Show();
                  
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            
            frm.Show();
        }
    }
}
