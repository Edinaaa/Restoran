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
    public partial class KombinacijaDetaljiPage : ContentPage
    {
        KombinacijeDetaljiViewModel model = null;
        public KombinacijaDetaljiPage()
        {
            InitializeComponent();
            BindingContext =model=new KombinacijeDetaljiViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.OnAppearing();
        }
    }
}