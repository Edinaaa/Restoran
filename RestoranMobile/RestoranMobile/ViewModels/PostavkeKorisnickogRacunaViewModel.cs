using Restoran.Model;
using Restoran.Model.Request;
using RestoranMobile.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
   public class PostavkeKorisnickogRacunaViewModel: BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupac");
        private Korisnik _korisnik;
        private string _lozinka;
        private string _lozinkaPotvrda;
        private bool _zensko;
        private bool _musko;



        public Korisnik Korisnik { get { return _korisnik; } set { SetProperty(ref _korisnik, value); } }
        public string Lozinka { get { return _lozinka; } set { SetProperty(ref _lozinka, value); } }
        public string LozinkaPotvrda { get { return _lozinkaPotvrda; } set { SetProperty(ref _lozinkaPotvrda, value); } }

        public bool Zensko
        {
            get { return _zensko; }
            set
            {
                SetProperty(ref _zensko, value);
                if (value==true)
                {
                    Musko = false;
                } 
            }
        }
        public bool Musko { get { return _musko; } 
            set { 
                SetProperty(ref _musko, value);
                if (value == true)
                {
                    Zensko = false;
                }
            }
        }

        private bool Validiraj()
        {
            if (string.IsNullOrWhiteSpace(Korisnik.Ime) ||
                string.IsNullOrWhiteSpace(Korisnik.Prezime) ||
                string.IsNullOrWhiteSpace(Korisnik.KorisnickoIme) ||
                string.IsNullOrWhiteSpace(Lozinka) ||
                string.IsNullOrWhiteSpace(LozinkaPotvrda) ||
                (!Musko && !Zensko)
             )
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Sva polja su obavezna.", "Zatvori.");
                return false;
            }
            else if (Korisnik.Ime.Length > 30 || Korisnik.Prezime.Length > 30 || Korisnik.KorisnickoIme.Length > 30)
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
            return true;
        }
        public PostavkeKorisnickogRacunaViewModel() {
            SetKorisnik();
            Title = "Postavke korisnickog racuna";

        }
        private async void SetKorisnik() {

         Korisnik=  await _service.GetById<Korisnik>(Singleton.IdKorisnika);
            if (Korisnik.Spol.Equals("Z"))
            {
                Zensko = true;
            }
            else
            {
                Musko = true;
            }
        }
        public async void UpdateKorisnik()
        {
            if (Validiraj())
            {
                KorisniciUpsertReqests r = new KorisniciUpsertReqests()
                {
                    Ime = Korisnik.Ime,
                    Prezime = Korisnik.Prezime,
                    KorisnickoIme = Korisnik.KorisnickoIme,
                    Password = Lozinka,
                    PasswordPotvrda = LozinkaPotvrda,
                    DatumRodenja = Korisnik.DatumRodenja


                };

                if (Zensko)
                {
                    r.Spol = "Z";
                }
                else
                {
                    r.Spol = "M";
                }
                Korisnik k = await _service.Update<Korisnik>(Singleton.IdKorisnika, r);
                if (k == null || !Korisnik.KorisnickoIme.Equals(APIService.username) || !Lozinka.Equals(APIService.password))
                {
                    await Shell.Current.GoToAsync("//LoginPage");
                }
            }
        
        }

    }
}
