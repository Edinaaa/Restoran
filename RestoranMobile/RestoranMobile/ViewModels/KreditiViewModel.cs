using Restoran.Model;
using RestoranMobile.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestoranMobile.ViewModels
{
  public  class KreditiViewModel: BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupac");
        private Korisnik _korisnik;

        public Korisnik Korisnik { get { return _korisnik; } set { SetProperty(ref _korisnik, value); } }
        public KreditiViewModel()
        {
          
            Title = "Krediti";

        }
        private async void SetKorisnik()
        {

            Korisnik = await _service.GetById<Korisnik>(Singleton.IdKorisnika);
          
        }

        internal void OnAppearing()
        {
            IsBusy = true;
            SetKorisnik();
        }
    }
}
