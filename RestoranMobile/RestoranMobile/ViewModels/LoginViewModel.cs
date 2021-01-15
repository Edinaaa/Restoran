using RestoranMobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Restoran.Model;
using RestoranMobile.Helper;
using Restoran.Model.Request;

namespace RestoranMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private APIService serviceKupac = new APIService("Kupac");

        public ICommand LoginCommand { get; }
        string _username = "edina";
        string _password = "1234";
        bool _musko ;
        bool _zensko;
        DateTime _datumRodenja;


        public string Username {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public bool Musko
        {
            get { return _musko; }
            set { SetProperty(ref _musko, value); }
        }
        public bool Zensko
        {
            get { return _zensko; }
            set { SetProperty(ref _zensko, value); }
        }
        public DateTime DatumRodenja
        {
            get { return _datumRodenja; }
            set { SetProperty(ref _datumRodenja, value); }
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await OnLoginClicked());
        }
        public async void OnClickedLogin()
        {
          
            try
            {

                 if (!String.IsNullOrWhiteSpace(Username) && !String.IsNullOrWhiteSpace(Password))
                {
                    APIService.username = Username;
                    APIService.password = Password;
                    KorisniciSeachRequest r = new KorisniciSeachRequest() { KorisnickoIme = Username };
                      var k = await serviceKupac.Get<List<Korisnik>>(r);
              
                    Singleton.IdKorisnika = k[0].KorisnikId;

                }
                else
                {
                   
                    KorisniciUpsertReqests requests = new KorisniciUpsertReqests() { 
                   
                    DatumRodenja=DatumRodenja
                    
                    };
                    if (Musko && !Zensko)
                    {
                        requests.Spol = "M";
                    }
                    else
                    {
                        requests.Spol = "Z";

                    }
                    Korisnik novi = await serviceKupac.Insert<Restoran.Model.Korisnik>(requests);
                    if (novi!=null)
                    {
                        APIService.username = novi.KorisnickoIme;
                        APIService.password = novi.KorisnickoIme;
                        Singleton.IdKorisnika = novi.KorisnikId;
                    }
                   
                }

                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
         async Task OnLoginClicked()
        {
            APIService.username = Username;
            APIService.password = Password;
            try
            {
                KorisniciSeachRequest r = new KorisniciSeachRequest() { KorisnickoIme=Username};
                var k= await serviceKupac.Get<List<Korisnik>>(r);
                Singleton.IdKorisnika = k[0].KorisnikId;

                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            {

                throw;
            }
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            // await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
