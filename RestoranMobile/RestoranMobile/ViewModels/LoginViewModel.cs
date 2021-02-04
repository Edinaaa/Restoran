using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Restoran.Model;
using RestoranMobile.Helper;
using Restoran.Model.Request;

namespace RestoranMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private APIService serviceKupac = new APIService("Kupac");

    //    public ICommand LoginCommand { get; }
        string _username;
        string _password;
     


        public string Username {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
    
        public LoginViewModel()
        {
           // LoginCommand = new Command(async () => await OnLoginClicked());
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
               

                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            {
                
                    await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani.", "OK");
              
            }
        }
  /*       async Task OnLoginClicked()
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
   */ 
    }
}
