using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RestoranWinUI.Korisnici
{
    public partial class frmKorisnik : Form
    {
        private APIService service = new APIService("Korisnik");
        private APIService ulogeService = new APIService("Uloge");
        private APIService korisnikUlogeService = new APIService("KorisnikUloge");

        int? _id = null;
        public KorisniciUpsertReqests request { get; set; } = new KorisniciUpsertReqests();
        private List<int> uloge;
        private List<Restoran.Model.Uloge> ListaUloga;
        public string Opcija { get; set; }
        public frmKorisnik(int? id = null)
        {
            InitializeComponent();

            _id = id;
        }

        private async void frmKorisnik_Load(object sender, EventArgs e)
        {
            ListaUloga = await ulogeService.Get<List<Restoran.Model.Uloge>>(null);
            clbUloge.DataSource = ListaUloga;

            clbUloge.DisplayMember = "Naziv";
            if (_id != null)
            {
                var korisnik = await service.GetById<Restoran.Model.Korisnik>(_id);
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                pbxSlika.Image = Global.ByteToImage(korisnik.Slika);
                request.Slika = korisnik.Slika;
                if (korisnik.Spol == "M")
                {
                    rbtnMusko.Checked = true;
                }
                else if (korisnik.Spol == "Z")
                {
                    rbtnZensko.Checked = true;
                }
                dtpDatumRodenja.Value = korisnik.DatumRodenja;
                if (korisnik.DatumZaposljavanja != null)
                {
                    dtpDatumZaposljavanja.Value = (DateTime)korisnik.DatumZaposljavanja;

                }
                KorisnikUlogeSerachRequest requestKu = new KorisnikUlogeSerachRequest() { KorisnikId = (int)_id };
                List<Restoran.Model.KorisnikUloga> ku = await korisnikUlogeService.Get<List<Restoran.Model.KorisnikUloga>>(requestKu);
                for (int i = 0; i < ListaUloga.Count; i++)
                {

                    foreach (var x in ku)
                    {
                        if (ListaUloga[i].UlogeId == x.UlogeId)
                        {
                            clbUloge.SetItemChecked(i, true);
                        }
                    }
                }



            }
        }
        void setUloge()
        {
            uloge = clbUloge.CheckedItems.Cast<Restoran.Model.Uloge>().Select(x => x.UlogeId).ToList();
        }
        private void SetRequest() {
            setUloge();
            string spol = " ";
            if (rbtnMusko.Checked)
            {
                spol = "M";
            }
            else if (rbtnZensko.Checked)
            {
                spol = "Z";
            }



            request.Ime = txtIme.Text;
            request.Prezime = txtPrezime.Text;
            request.KorisnickoIme = txtKorisnickoIme.Text;
            request.Password = txtPassword.Text;
            request.PasswordPotvrda = txtPasswordPotvrda.Text;
            request.DatumRodenja = dtpDatumRodenja.Value;
            request.DatumZaposljavanja = dtpDatumZaposljavanja.Value;
            request.Uloge = uloge;
            request.Spol = spol;
        }
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SetRequest();

                Restoran.Model.Korisnik entity = null;
                if (_id == null)
                {
                    try
                    {
                        entity = await service.Insert<Restoran.Model.Korisnik>(request);
                        if (entity != null)
                        {

                            if (MessageBox.Show("Uspjesno dodan korisnik.", "Dodavanje korisnika", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                Opcija = Global.Update;
                                Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Autorizacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    entity = await service.Update<Restoran.Model.Korisnik>(_id, request);
                    if (entity != null)
                    {
                        if (MessageBox.Show("Podatci o koriskniku su uspješno izmjenjeni.", "Izmjena", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            
                            Close();
                        }
                    }
                }

            }


        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            request.Slika = Global.SetSlika(ref openFileDialog1, ref txtSlika, request.Slika, ref pbxSlika);

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtIme, e, errorProvider);
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtPrezime, e, errorProvider);

        }

        private void rbtnZensko_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingSpolObaveznoPolje(ref rbtnZensko, rbtnMusko, e, errorProvider);
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtKorisnickoIme, e, errorProvider);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_id==null)
            {
                Global.ValidatingObaveznoPolje(ref txtPassword, e, errorProvider);

            }


        }

        private void txtPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (_id==null)
            {
                Global.ValidatingObaveznoPolje(ref txtPasswordPotvrda, e, errorProvider);

            }
            Global.ValidatingPassPassPotvrda(ref txtPasswordPotvrda, txtPassword, e, errorProvider);

        }

        private void rbtnMusko_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingSpolObaveznoPolje(ref rbtnMusko, rbtnZensko, e, errorProvider);

        }
        bool IsZaposlenik()
        {
            bool Zapozleni = false;
            setUloge();

            foreach (var item in ListaUloga)
            {

                foreach (var x in uloge)
                {

                    if (x == item.UlogeId && (item.Naziv == "Administrator" || item.Naziv == "Konobar"))
                    { Zapozleni = true; }
                }

            }
            return Zapozleni;
        }
        private void dtpDatumRodenja_Validating(object sender, CancelEventArgs e)
        {
            if (IsZaposlenik())
            {

                Global.ValidatingDatumManji(DateTime.Now,ref dtpDatumRodenja,15,"Zaposlen ne moze biti mladji od 15g.", e, errorProvider);

            }
        }

        private void dtpDatumZaposljavanja_Validating(object sender, CancelEventArgs e)
        {
            if (IsZaposlenik())
            {

                Global.ValidatingDatumVeci(DateTime.Now, ref dtpDatumZaposljavanja, "Datum zaposljavanja ne moze biti veci od trenutrnog.", e, errorProvider);

            }
        }

     
        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (_id==null)
            {
                Global.ValidatingObaveznoPolje(ref txtSlika, e, errorProvider);

            }
        }

        private void clbUloge_Validating(object sender, CancelEventArgs e)
        {
           
          Global.ValidatingObaveznoPoljeClb(ref clbUloge, clbUloge.CheckedItems.Count < 1, e, errorProvider);
           
        }
    }
}
