using Newtonsoft.Json;
using Restoran.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Restoran.Model.Request;
using System.Collections.ObjectModel;
using RestoranMobile.Models;
using RestoranMobile.Helper;
using RestoranMobile.Views;

namespace RestoranMobile.ViewModels
{

    public  class NarudzbaViewModel:BaseViewModel
    {
        private readonly APIService _narudzbaService = new APIService("Narudzba");
        public ObservableCollection<Item> Artikals { get; set; } = new ObservableCollection<Item>();

        private bool _PlacanjeKreditima;
        private int _BrojStola;
        public bool PlacanjeKreditima { get { return _PlacanjeKreditima; } set { SetProperty(ref _PlacanjeKreditima, value); } }
        public int BrojStola { get { return _BrojStola; } set { SetProperty(ref _BrojStola, value); } }

        public void OnAppearing()
        {
            IsBusy = true;
            Title = "Narudzba";
            PlacanjeKreditima = false;
            Artikals.Clear();
           
            foreach (var item in Singleton.GetSelektovaneArtikle())
            {
                Artikals.Add(item);
            }
            
        }
        public void BtnPonistiNarudzbu() {
            Singleton.IzvrsenaPonistenaNarudba();

        }
        private bool Validiraj() {
            bool validno = true;
            foreach (var item in Artikals)
            {
                if (item.Kolicina >50)
                {
                    validno = false;
                }

            }
            if (!validno)
            {
               Application.Current.MainPage.DisplayAlert("Validacija", "Koicina proizvoda ne moze biti veca od 50.", "Zatvori");

            }
            else if (BrojStola<1)
            {
                Application.Current.MainPage.DisplayAlert("Validacija", "Boj stola je obavezno polje.", "Zatvori");
                validno = false;
            }
            return validno;
        }

        public async Task BtnIzvrsiNarudzbu() {
            if (Validiraj())
            {
                List<StavkaNarudzbe> sn = new List<StavkaNarudzbe>();
                foreach (var item in Artikals)
                {
                    if (item.Kolicina > 0)
                    {
                       
                        sn.Add(new StavkaNarudzbe()
                        {
                            KombinacijaId =  item.KombinacijaId!=null? item.KombinacijaId : 0,

                            StavkeMeniaId = item.StavkeMeniaId==null ? 0 : item.StavkeMeniaId,
                            Cijena = item.Cijena * item.Kolicina,
                            CijenaSaPdv = item.CijenaSaPdv * item.Kolicina,
                            Pdv = int.Parse(( item.PDV * item.Kolicina).ToString()),
                            Kolicina = item.Kolicina,
                            NarudzbaId = 0
                        });
                    }

                }

                NarudzbaUpsertRequest narudzbaUpsertRequest = new NarudzbaUpsertRequest()
                {
                    BrojStola = BrojStola,
                    PlacanjeKreditima = PlacanjeKreditima,
                    Stavke = sn,
                    KorisnikId = Singleton.IdKorisnika
                };
                Singleton.IzvrsenaPonistenaNarudba();
                Narudzba n = await _narudzbaService.Insert<Restoran.Model.Narudzba>(narudzbaUpsertRequest);

                await Shell.Current.GoToAsync($"{nameof(IzvrsenaNarudzbaPage)}?{nameof(IzvrsenaNarudzbaViewModel.NarudzbaId)}={n.NarudzbaId.ToString()}");
            }
        }
         
    }
}
