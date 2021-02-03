using Restoran.Model;
using Restoran.Model.Request;
using RestoranMobile.Helper;
using RestoranMobile.Models;
using RestoranMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace RestoranMobile.ViewModels
{
    [QueryProperty(nameof(NarudzbaId), nameof(NarudzbaId))]
    public class IzvrsenaNarudzbaViewModel : BaseViewModel
    {
        private readonly APIService service = new APIService("Narudzba");
        private readonly APIService serviceStavke = new APIService("StavkeNarudzbe");
        private readonly APIService serviceZahtjevi = new APIService("Zahtjev");
        private readonly APIService serviceStavkeZahtjeva = new APIService("StavkeZahtjeva");


        private string narudzbaId;
        private string odabraniZahtjev;
        private string stanjeNarudzbe;
        private double _ukupno;
        private int _narudzbaId;
        private bool _isKombinacija;
        private bool _isStavkaMenija;
        private bool odobrena;

        private List<Zahtjev> zahtjevi;

        public string[] Zahtjevi;
        public ObservableCollection<Item> Stavke { get; set; } = new ObservableCollection<Item>();
        public string OdabraniZahtjev { get { return odabraniZahtjev; } 
            set { SetProperty(ref odabraniZahtjev, value);
                OnSetOdabraniZahtjev();
            } }

        public bool IsKombinacija
        {
            get { return _isKombinacija; }
            set
            {
                SetProperty(ref _isKombinacija, value);
            }
        }
        public bool IsStavkeMenija
        {
            get { return _isStavkaMenija; }
            set
            {
                SetProperty(ref _isStavkaMenija, value);
            }
        }
        public string NarudzbaId { get { return narudzbaId; } set { SetProperty(ref narudzbaId, value); OnSetNarudzbaId(value); } }
        public int Narudzba_Id { get { return _narudzbaId; } set { SetProperty(ref _narudzbaId, value);  } }
        public double Ukupno { get { return _ukupno; } set { SetProperty(ref _ukupno, value); } }
        public string StanjeNarudzbe { get { return stanjeNarudzbe; } set { SetProperty(ref stanjeNarudzbe, value); } }

        public Narudzba Narudzba { get; set;  }
        private void SetStanje() {
            odobrena = false;
            string stanje;
            if (Narudzba.Odbijena)
            {
                stanje = "Narudžba je odbijena.";
            }
            else if (Narudzba.Odobrena)
            {
                stanje = "Narudžba je odobrena.";
                odobrena = true;
            }
            else if (Narudzba.Naplaceno)
            {
                stanje = "Narudžba je naplćena.";
            }
            else
            {
                stanje = "Narudžba nije odobrena.";
                
            }
            StanjeNarudzbe = stanje;
           
        }
        private async void SetZahtjevi()
        {
            zahtjevi = await serviceZahtjevi.Get<List<Zahtjev>>(null);
            Zahtjevi = new string[zahtjevi.Count+ 1];
            Zahtjevi[0] = "Dodaj novi zahtjev";
            for (int i = 0; i < zahtjevi.Count; i++)
            {
                Zahtjevi[i+1] = zahtjevi[i].Naziv;

            }
        }
        private async void SetStavke() {
            StavkeNarudzbeSearchRequest request = new StavkeNarudzbeSearchRequest() { NaruszbaId = Narudzba.NarudzbaId };
            var lista = await serviceStavke.Get<List<StavkaNarudzbe>>(request);
    
            Ukupno = 0;
            foreach (var item in lista)
            {
               
                Stavke.Add(new Item() { 
                Kolicina=item.Kolicina,
                KategorijaId=0,
                Selected=false,
                Cijena=item.Cijena,
                CijenaSaPdv=item.CijenaSaPdv,
                KombinacijaId=item.KombinacijaId,
                StavkeMenijaId=item.StavkeMenijaId,
                PDV=item.Pdv,
                Slika= item.KombinacijaId==null? item.StavkeMenija.Artikal.Slika: item.Kombinacija.Slika,
                Naziv= item.KombinacijaId==null? item.StavkeMenija.Artikal.Naziv: item.Kombinacija.Naziv
                });
                Ukupno += item.CijenaSaPdv;

            }
        }
        public async void OnSetNarudzbaId(string value) {

            Title = "Detalji narudzbe";
             Narudzba=   await service.GetById<Narudzba>(int.Parse(value));
            Narudzba_Id = Narudzba.NarudzbaId;
            SetStanje();
            SetStavke();
            SetZahtjevi();
        }
        private async void OnSetOdabraniZahtjev() {
            int id =0;
            foreach (var item in zahtjevi)
            {
                if (item.Naziv==OdabraniZahtjev)
                {
                    id = item.ZahtjevId;
                }
            }
            if (OdabraniZahtjev.Equals("Dodaj novi zahtjev"))
            {
                await Shell.Current.GoToAsync($"{nameof(NoviZahtjevPage)}?{nameof(NoviZahtjevViewModel)}");
            }
              else  if (id==0)
            {
                return;
            }
            else
            {

                StavkeZahtjevaUpsertRequest request = new StavkeZahtjevaUpsertRequest()
                {
                    ZahtjevId = id,
                    ZahtjevObradjen = false,
                    KorisnikId = Singleton.IdKorisnika
                };
                await serviceStavkeZahtjeva.Insert<StavkeZahtjeva>(request);
            }
        }
        public async void OnPlatiNarudzbu()
        {
            if (odobrena)
            {
                NarudzbaUpsertRequest request = new NarudzbaUpsertRequest()
                {

                    Naplati = true
                };

                var n = await service.Update<Narudzba>(Narudzba_Id, request);

               
            }
            else
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Narudžba", "Narudžbu nije moguče platiti. " + StanjeNarudzbe, "Ok");

            }

        }

    }
}
