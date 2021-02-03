using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
   public class NoviZahtjevViewModel: BaseViewModel
    {
        private APIService service = new APIService("Zahtjev");

        string _naziv;



        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
        public NoviZahtjevViewModel() { }

        internal async void OnButtonClicked()
        {
            bool postoji = false;
            var Zahtjevi =await service.Get<List<Restoran.Model.Zahtjev>>(null);
            foreach (var item in Zahtjevi)
            {
                if (item.Naziv.Equals(Naziv))
                {
                    postoji = true;
                }
            }
            if (string.IsNullOrWhiteSpace(Naziv) || Naziv.Length > 100)
            {
                await Application.Current.MainPage.DisplayAlert("Novi zahtjev", "Zahtjev nije dodan, mozete unjeti tekst manji od 100 kataktera.", "Zatvori");

            }
            else if (postoji)
            {
                await Application.Current.MainPage.DisplayAlert("Novi zahtjev", "Zahtjev koji pokusavate dodati vec postoji.", "Zatvori");

            }
            else
            {
                ZahtjevUpsertRequest r = new ZahtjevUpsertRequest()
                {
                    Naziv = Naziv
                };

                Zahtjev novi = await service.Insert<Zahtjev>(r);
                if (novi != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Novi zahtjev", "Uspjesno dodan zahtjev.", "Zatvori");
                   
                }

            }
        }

        internal void OnAppearing()
        {
            Title = "Novi zahtjev";
        }
    }
}
