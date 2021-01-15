using Restoran.Model;
using Restoran.Model.Request;
using RestoranMobile.Helper;
using RestoranMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace RestoranMobile.ViewModels
{
  public  class NarudzbeViewModel:BaseViewModel
    {
        private readonly APIService service = new APIService("Narudzba");
        public ObservableCollection<Narudzba> Narudzbe { get; set; } = new ObservableCollection<Narudzba>();
        public Command<Narudzba> NarudzbaTapped { get; }

        public NarudzbeViewModel() {
            Title = "Narudzbe";
            NarudzbaTapped = new Command<Narudzba>(OnNarudzbaSelected);
            SetNarudzbe();
        }

        private async void OnNarudzbaSelected(Narudzba obj)
        {
            if (obj==null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(IzvrsenaNarudzbaPage)}?{nameof(IzvrsenaNarudzbaViewModel.NarudzbaId)}={obj.NarudzbaId}");

        }

        public async void SetNarudzbe() {

            NarudzbaSearchRequest nr = new NarudzbaSearchRequest() { DatumNarudzbe=DateTime.Now, PretragaPoDatumu=true, KorisnikId=Singleton.IdKorisnika
            };
          
            var lista = await service.Get<List<Narudzba>>(nr);
            foreach (var item in lista)
            {
                Narudzbe.Add(item);
            }
        
        }
        

    }
}
