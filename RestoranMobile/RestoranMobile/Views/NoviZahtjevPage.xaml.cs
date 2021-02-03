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
    public partial class NoviZahtjevPage : ContentPage
    {
        NoviZahtjevViewModel model;
        public NoviZahtjevPage()
        {
            InitializeComponent();
            this.BindingContext = model = new NoviZahtjevViewModel();
        }
        protected override void OnAppearing()
        {

            base.OnAppearing();
            model.OnAppearing();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            model.OnButtonClicked();
        }
    }
}