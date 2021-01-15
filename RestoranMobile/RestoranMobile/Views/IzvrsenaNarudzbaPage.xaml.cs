using RestoranMobile.ViewModels;
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
    public partial class IzvrsenaNarudzbaPage : ContentPage
    {
        public IzvrsenaNarudzbaViewModel model { get; set; }
        public IzvrsenaNarudzbaPage()
        {
            InitializeComponent();
            BindingContext = model = new IzvrsenaNarudzbaViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
        model.OdabraniZahtjev=await DisplayActionSheet("Zahtjevi", "Zatvori", null,model.Zahtjevi);

        }

        private void Button_Plati_Clicked(object sender, EventArgs e)
        {

            model.OnPlatiNarudzbu();
        }
    }
}