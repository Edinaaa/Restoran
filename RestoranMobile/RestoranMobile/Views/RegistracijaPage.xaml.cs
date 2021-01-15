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
    public partial class RegistracijaPage : ContentPage
    {
        RegistracijaViewModel model = null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistracijaViewModel();
        }

        private void DatumRodenja_DateSelected(object sender, DateChangedEventArgs e)
        {
            model.DatumRodenja = e.NewDate;
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
          model.OnBtnSnimiClicked();
            Application.Current.MainPage = new LoginPage();
        }
    }
}