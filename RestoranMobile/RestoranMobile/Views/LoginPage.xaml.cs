using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestoranMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;

namespace RestoranMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel model;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = model=new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.OnClickedLogin();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
    }
}