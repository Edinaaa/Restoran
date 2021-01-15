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
    public partial class PonudePage : ContentPage
    {
        PonudaViewModel model= null;
        public PonudePage()
        {
            InitializeComponent();
            BindingContext = model = new PonudaViewModel();
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
          await  model.SetPonude();
        }
    }
}