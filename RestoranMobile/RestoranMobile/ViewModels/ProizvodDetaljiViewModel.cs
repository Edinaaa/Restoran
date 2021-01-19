using Restoran.Model;
using RestoranMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
    [QueryProperty(nameof(StavkeMeniaId), nameof(StavkeMeniaId))]
  public  class ProizvodDetaljiViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("StavkeMenia");
        private string stavkeMeniaId;
  
        private Artikal artikal;

        public string StavkeMeniaId
        {
            get { return stavkeMeniaId; }
            set
            {
                SetProperty(ref stavkeMeniaId, value);
                OnAtrikalIdSet(value);
            }
        }

        public Artikal Artikal
        {
            get { return artikal; }
            set
            {
                SetProperty(ref artikal, value);
              
            }
        }
        private async void OnAtrikalIdSet(string value)
        {
            Title = "Datalji proizvoda";
            StavkeMenija sm=await  service.GetById<Restoran.Model.StavkeMenija>(int.Parse(value));
            Artikal = new Artikal() {
                Slika = sm.Artikal.Slika,
                Naziv= sm.Artikal.Naziv,
                Cijena=sm.Cijena,
                CijenaSaPdv = sm.CijenaSaPDV,
            PDV = sm.PDV,
            Sastav = sm.Artikal.Sastav,
            Kategorija = sm.Kategorija,
            JedinicaMjere = sm.Artikal.JedinicaMjere,
            Popust = sm.Popust,
            Kolicina = sm.Artikal.Kolicina,


        };
          
          
           
        }
    }
}
