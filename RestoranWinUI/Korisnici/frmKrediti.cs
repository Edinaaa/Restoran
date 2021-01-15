using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restoran.Model;
using Restoran.Model.Request;

namespace RestoranWinUI.Korisnici
{
    public partial class frmKrediti : Form
    {
        private APIService service = new APIService("Korisnik");
        Korisnik korisnik = null;
        public frmKrediti()
        {
            InitializeComponent();
        }

        private  void frmKrediti_Load(object sender, EventArgs e)
        {

        }


        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (korisnik==null)
            {
                MessageBox.Show("Morate pronaci korisnika kojem zelite izmjenitit stanje kredita!","Greska",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            KorisniciUpsertReqests r = new KorisniciUpsertReqests() { 
            IznosKredita= double.Parse( txtIznosUplate.Text.ToString()),//salje se samo koliko je dodano, a na api cese sabrati sa trenutnim stanjem
            Ime=korisnik.Ime,
            DatumRodenja=korisnik.DatumRodenja,
            Prezime=korisnik.Prezime,
            Spol=korisnik.Spol,
            KorisnickoIme=korisnik.KorisnickoIme,
            DatumZaposljavanja=korisnik.DatumZaposljavanja,
            Slika=korisnik.Slika
           
            
            };
            await service.Update<Restoran.Model.Korisnik>(korisnik.KorisnikId, r);
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            frmPretragaKorisnika frm = new frmPretragaKorisnika();
            frm.ShowDialog();
           
            korisnik = await service.GetById<Korisnik>(frm.SendData());
            frm.Close();
            txtIznosKredita.Text = korisnik.IznosKredita.ToString();
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
        }
    }
}
