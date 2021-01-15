using Restoran.Model;
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
    public partial class PostavkeKorisnickogRacunaPage : ContentPage
    {
        PostavkeKorisnickogRacunaViewModel model = null;
        public PostavkeKorisnickogRacunaPage()
        {
            InitializeComponent();
            BindingContext = model = new PostavkeKorisnickogRacunaViewModel();
        }

        private void DatumRodenja_DateSelected(object sender, DateChangedEventArgs e)
        {
            model.Korisnik.DatumRodenja = e.NewDate;
            DisplayAlert("Datum", e.NewDate.ToString(), "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.UpdateKorisnik();
        }
    }
}