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
    public partial class PriozvodiPage : ContentPage
    {
        ProizvodiViewModel model = null;

        public PriozvodiPage()
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiViewModel();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
         model.OnAppearing();
            await model.PopuniKategorije();
            if (KategorijePicker.Items.Count==0)
            {
                foreach (var item in model.Kategorijas)
                {
                    KategorijePicker.Items.Add(item.Naziv);
                }

            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Naruci();
        }

        private void KategorijePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int index = picker.SelectedIndex;
            model.PretragaPoKategoriji(index);
        }

      
    }
}