using System;
using System.Collections.Generic;
using RestoranMobile.ViewModels;
using RestoranMobile.Views;
using Xamarin.Forms;

namespace RestoranMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
            Routing.RegisterRoute(nameof(ProizvodiDetaljiPage), typeof(ProizvodiDetaljiPage));
            Routing.RegisterRoute(nameof(KombinacijaDetaljiPage), typeof(KombinacijaDetaljiPage));

            Routing.RegisterRoute(nameof(IzvrsenaNarudzbaPage), typeof(IzvrsenaNarudzbaPage));
            Routing.RegisterRoute(nameof(KombinacijePonudePage), typeof(KombinacijePonudePage));

            Routing.RegisterRoute(nameof(NarudzbaPage), typeof(NarudzbaPage));

           
       
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
