using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
 public   class RegistracijaViewModel: BaseViewModel
    {
        APIService service = new APIService("Kupac");
        private string ime;
        private string prezime;
        private bool spolM;
        private bool spolZ;
        private DateTime datumRodenja;
        private string korisnickoIme;
        private string lozinka;
        private string lozinkaPotvrda;

        public string Ime { get { return ime; }set { SetProperty(ref ime, value); } }
        public string Prezime { get { return prezime; } set { SetProperty(ref prezime, value); } }
        public bool SpolM { get { return spolM; } set { SetProperty(ref spolM, value); } }
        public bool SpolZ { get { return spolZ; } set { SetProperty(ref spolZ, value); } }
        public DateTime DatumRodenja { get { return datumRodenja; } set { SetProperty(ref datumRodenja, value); } }
        public string KorisnickoIme { get { return korisnickoIme; } set { SetProperty(ref korisnickoIme, value); } }
        public string Lozinka { get { return lozinka; } set { SetProperty(ref lozinka, value); } }
        public string LozinkaPotvrda { get { return lozinkaPotvrda; } set { SetProperty(ref lozinkaPotvrda, value); } }
       public KorisniciUpsertReqests reqests = new KorisniciUpsertReqests();
        public void OnAppiring() {

            IsBusy = true;
        }
      public  RegistracijaViewModel() {
            Title = "Registracija";
        
        
        }
        private bool Validiraj() {
            if (string.IsNullOrWhiteSpace(Ime) ||
                string.IsNullOrWhiteSpace(Prezime) ||
                string.IsNullOrWhiteSpace(KorisnickoIme) ||
                string.IsNullOrWhiteSpace(Lozinka) ||
                string.IsNullOrWhiteSpace(LozinkaPotvrda) ||
                (!SpolM && !SpolZ)
             )
            {
                Application.Current.MainPage.DisplayAlert("Validacija","Sva polja su obavezna.","Zatvori.");
                return false;
            }
            else if (Ime.Length > 30 || Prezime.Length > 30 || korisnickoIme.Length > 30)
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Ime, prezime ili korisnicko ime ne mogu sadrzavati vise od 30 karaktera.", "Zatvori.");

                return false;


            }
            else if (Lozinka.Length > 50 || LozinkaPotvrda.Length > 50)
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Lozinka ne moze sadrzavati vise od 50 karaktera.", "Zatvori.");

                return false;

            }
            else if (!Lozinka.Equals(LozinkaPotvrda))
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Lozinka i lozina potvrda nisu jednake.", "Zatvori.");

                return false;

            }
            else if (DateTime.Now.Year- datumRodenja.Year >120)
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Datum rodenja ne moze biti stariji od 120g.", "Zatvori.");

                return false;

            }
            else if (DateTime.Now.Year - datumRodenja.Year <8)
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Kupac ne moze biti mladji od 8g.", "Zatvori.");

                return false;

            }
            return true;
        }
        public async void OnBtnSnimiClicked() {

            if (Validiraj())
            {
                reqests.Ime = Ime;
                reqests.Prezime = Prezime;
                reqests.KorisnickoIme = KorisnickoIme;
                reqests.Password = Lozinka;
                reqests.PasswordPotvrda = LozinkaPotvrda;
                reqests.DatumRodenja = DatumRodenja.Date;

                if (SpolM && !SpolZ)
                {
                    reqests.Spol = "M";
                }
                else
                {
                    reqests.Spol = "Z";
                }

                Korisnik korisnik = await service.Insert<Restoran.Model.Korisnik>(reqests);
                if (korisnik!=null)
                {
                  await  Application.Current.MainPage.DisplayAlert("Regirstracija", "Uspjesna registracija, sada mozete se logirati sa vasim korisnickim imenom i lozinkom.", "Zatvori.");

                }

            }
          
        }
    }
}
