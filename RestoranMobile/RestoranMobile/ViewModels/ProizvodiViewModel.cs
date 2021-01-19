using Newtonsoft.Json;
using Restoran.Model;
using Restoran.Model.Request;
using RestoranMobile.Helper;
using RestoranMobile.Models;
using RestoranMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace RestoranMobile.ViewModels
{

    public class ProizvodiViewModel : BaseViewModel
    {
        private readonly APIService _kategorijaService = new APIService("Kategorija");
        private readonly APIService _stavkeService = new APIService("StavkeMenija");
        private readonly APIService _meniService = new APIService("Meni");
        private readonly APIService _preporukaService = new APIService("Preporuka");

        public List<Kategorija> Kategorijas { get; set; } = new List<Kategorija>();
        public ObservableCollection<Item> ProizvodiList { get; set; } = new ObservableCollection<Item>();
        public ObservableCollection<Item> PreporukaList { get; set; } = new ObservableCollection<Item>();


        private string _nazivProizvoda;

        private Item _selectedArtikal;
        public ICommand InitCommand { get; set; }
        public ICommand NaruciCommand { get; set; }
        public Command<Item> ArtikalTapped { get; }
        public Command<Item> ArtikalDetalji { get; }


        public ProizvodiViewModel() {

            Title = "Proizvodi";
            InitCommand = new Command(async () => await Init());
            NaruciCommand = new Command(async () => await Naruci());
            ArtikalTapped = new Command<Item>(OnArtikalSelected);
            ArtikalDetalji = new Command<Item>(OnArtikalDetalji);

        }
        public void OnAppearing()
        {
            IsBusy = true;


        }

        public Item SelectedArtikal
        {
            get => _selectedArtikal;
            set
            {
                if (_selectedArtikal != value)
                {


                    SetProperty(ref _selectedArtikal, value);

                    OnArtikalSelected(value);
                }

            }
        }
        public string NazivProizvoda {
            get { return _nazivProizvoda; }
            set { SetProperty(ref _nazivProizvoda, value);
                PretragaPoNazivu(value);
            }
        }



        public async Task PopuniKategorije() {

            Kategorijas = await _kategorijaService.Get<List<Kategorija>>(null);

        }
        public void PretragaPoKategoriji(int index) {

            Singleton.UpdateProuzvodiListSvi(ProizvodiList);
            Singleton.UpdatePreporuka(PreporukaList);

            ProizvodiList.Clear();
            foreach (var item in Singleton.GetArtiklePoKategoriji(Kategorijas[index].KategorijaId))
            {
                ProizvodiList.Add(item);
            }


        }
        public void PretragaPoNazivu(string naziv) {
            Singleton.UpdateProuzvodiListSvi(ProizvodiList);
            Singleton.UpdatePreporuka(PreporukaList);

            ProizvodiList.Clear();

            foreach (var item in Singleton.GetArtiklePoNazivu(naziv))
            {
                ProizvodiList.Add(item);
            }
        }

        private async void OnArtikalDetalji(Item obj)
        {
            if (obj == null)
                return;

            if (obj.StavkeMenijaId!=null)
            {
                await Shell.Current.GoToAsync($"{nameof(ProizvodiDetaljiPage)}?{nameof(ProizvodDetaljiViewModel.StavkeMeniaId)}={obj.StavkeMenijaId.ToString()}");

            }
            else if (obj.KombinacijaId != null)
            {
                await Shell.Current.GoToAsync($"{nameof(KombinacijaDetaljiPage)}?{nameof(KombinacijeDetaljiViewModel.KombinacijaId)}={obj.KombinacijaId.ToString()}");

            }

        }
        private void OnArtikalSelected(Item obj)
        {
            if (obj == null)
                return;


            foreach (var item in ProizvodiList)
            {
                if ((obj.KombinacijaId != null && obj.KombinacijaId == item.KombinacijaId)||
                    (obj.StavkeMenijaId != null && obj.StavkeMenijaId == item.StavkeMenijaId))
                {

                    item.Selected = !item.Selected;

                }
            }
            foreach (var item in PreporukaList)
            {
                if ((obj.KombinacijaId != null && obj.KombinacijaId == item.KombinacijaId) ||
                    (obj.StavkeMenijaId != null && obj.StavkeMenijaId == item.StavkeMenijaId))
                {

                    item.Selected = !item.Selected;

                }
            }

        }
        public async Task Naruci()
        {
            Singleton.UpdateProuzvodiListSvi(ProizvodiList);

            Singleton.UpdatePreporuka(PreporukaList);

            await Shell.Current.GoToAsync(nameof(NarudzbaPage));
        }
        private async Task PopuniProizvodiList() {

            if (Singleton.ProizvodiListSvi.Count == 0 || Singleton.IsPonuda == true)
            {

                try
                {
                    MeniSearchRequest request = new MeniSearchRequest() { Vazeci = true };
                    var meni = await _meniService.Get<List<Meni>>(request);
                    StavkeMenijaSearchRequest smr = new StavkeMenijaSearchRequest() { MeniId = meni[0].MeniId };
                    var list = await _stavkeService.Get<List<StavkeMenija>>(smr);
                    Singleton.ProizvodiListSvi.Clear();
                    Singleton.SetPoizvodiList(list);

                }
                catch (Exception)
                {

                    throw;
                }

            }

            ProizvodiList.Clear();
            foreach (var item in Singleton.ProizvodiListSvi)
            {
                ProizvodiList.Add(item);
            }
        }
        private async Task PopuniPreporukaList()
        {
            if (Singleton.PreporukaList.Count()==0)
            {

                try
                {
                    PreporukaSerachRequest request = new PreporukaSerachRequest() { KorisnikId=Singleton.IdKorisnika};
                  var  preporukas = await _preporukaService.Get<List<Preporuka>>(request);
                    Singleton.PreporukaList.Clear();
                    Singleton.SetPreporukaList(preporukas);
                }
                catch (Exception)
                {

                    throw;
                }

            }

            PreporukaList.Clear();
            foreach (var item in Singleton.PreporukaList)
            {
                PreporukaList.Add(item);
               
            }
        }
        public async Task Init() {

            IsBusy = true;
         await   PopuniProizvodiList();
           await PopuniPreporukaList();
            IsBusy = false;
        }
    }
}
