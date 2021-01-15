using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestoranMobile.Views;
using System.Net.Http;
using Newtonsoft.Json;
namespace RestoranMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
