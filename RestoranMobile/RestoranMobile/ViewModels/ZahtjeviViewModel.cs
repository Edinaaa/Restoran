using Restoran.Model;
using Restoran.Model.Request;
using RestoranMobile.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
   public class ZahtjeviViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("Zahtjev");
        private readonly APIService serviceStavke = new APIService("StavkeZahtjeva");
        public string _nazivZahtejeva;
        public Command<Zahtjev> ZahtjevTapped { get; }
        public ICommand ZahtjeviCommand { get; set; }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        public ObservableCollection<Zahtjev> Zahtjevi { get; set; } = new ObservableCollection<Zahtjev>();
        public string NazivZahtejeva { get { return _nazivZahtejeva; } set { SetProperty(ref _nazivZahtejeva, value); } }
        public ZahtjeviViewModel() {

            Title = "Zahtjevi";
  
            ZahtjeviCommand = new Command( async ()=> await SetZahtjevi());
            ZahtjevTapped = new Command<Zahtjev>(OnZahtjevTapped);
        }

        private async void OnZahtjevTapped(Zahtjev obj)
        {
            if (obj==null)
            {
                return;
            }
            StavkeZahtjevaUpsertRequest r = new StavkeZahtjevaUpsertRequest() {
                ZahtjevId = obj.ZahtjevId,
                ZahtjevObradjen = false,
                KorisnikId=Singleton.IdKorisnika
            };

          await  serviceStavke.Insert<StavkeZahtjeva>(r);
          await  Application.Current.MainPage.DisplayAlert("Zahtjev","Uspjesno poslan zahtjev.","Zatvori");
        }

        public async Task SetZahtjevi() {
           
            IsBusy = true;
            try
            {
               
                Zahtjevi.Clear();
                var list = await service.Get<List<Zahtjev>>(null);
              
                foreach (var item in list)
                {
                    Zahtjevi.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
            finally
            { 
                IsBusy = false; 
            }
        }
    

        public async void DodajZahtjev()
        {
            if (string.IsNullOrWhiteSpace(NazivZahtejeva) || NazivZahtejeva.Length>100)
            {
                await Application.Current.MainPage.DisplayAlert("Novi zahtjev", "Zahtjev nije dodan, mozete unjeti tekst manji od 100 kataktera.", "Zatvori");

            }
            ZahtjevUpsertRequest r = new ZahtjevUpsertRequest()
            {
                Naziv=NazivZahtejeva
            };

            await service.Insert<Zahtjev>(r);
            await Application.Current.MainPage.DisplayAlert("Novi zahtjev", "Uspjesno dodan zahtjev.", "Zatvori");
        }

    }
}
