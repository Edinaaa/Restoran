﻿using RestoranMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestoranMobile.Views
{
  
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NarudzbaPage : ContentPage
    {
        NarudzbaViewModel model= null;
        public NarudzbaPage()
        {
            

            InitializeComponent();
            BindingContext =model= new NarudzbaViewModel();
        }
        protected override void OnAppearing()
        {

            base.OnAppearing();
           model.OnAppearing();
        }
        private void Button_Ponisti_Clicked(object sender, EventArgs e)
        {
             model.BtnPonistiNarudzbu();
        }

        private async void Button_Izvrsi_Clicked(object sender, EventArgs e)
        {
            await model.BtnIzvrsiNarudzbu();
        }
    }
}