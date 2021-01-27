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
    public partial class ProizvodiDetaljiPage : ContentPage
    {
        ProizvodDetaljiViewModel model = null;
        public ProizvodiDetaljiPage()
        {
            InitializeComponent();
            BindingContext =model=new ProizvodDetaljiViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            model.OnClickedDodajUNarudzbu();
        }
    }
}