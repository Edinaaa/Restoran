using Restoran.Model;
using Restoran.Model.Request;
using RestoranMobile.Helper;
using RestoranMobile.Models;
using RestoranMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
    [QueryProperty(nameof(PonudaId), nameof(PonudaId))]
    public   class KombinacijePonudeViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("Kombinacija");
        public ObservableCollection<Item> Kombinacije { get; set; } = new ObservableCollection<Item>();
        public Command<Item> KombinacijeTapped { get; }

        private string _ponudaId;
        private Item _selectedKombinacija;
        public ICommand InitCommand { get; set; }
        public ICommand NaruciCommand { get; set; }
        public Command<Item> KombinacijaDetalji { get; }
        public string PonudaId
        {
            get { return _ponudaId; }
            set
            {
                SetProperty(ref _ponudaId, value);
            }
        }
        public KombinacijePonudeViewModel()
        {
            Title = "Kombinacije";
            KombinacijeTapped = new Command<Item>(OnKombinacijaSelected);
        
            InitCommand = new Command(async () => await Init());
            NaruciCommand = new Command(async () => await Naruci());
            KombinacijaDetalji = new Command<Item>(OnKombinacijaDetalji);
        }

        private  void OnKombinacijaSelected(Item obj)
        {
            if (obj == null)
                return;


            foreach (var item in Kombinacije)
            {
                if (obj.KombinacijaId!=null && obj.KombinacijaId == item.KombinacijaId)
                {

                    item.Selected = !item.Selected;

                }
            }
        }

     
        public void OnAppearing()
        {
            IsBusy = true;


        }

        public Item SelectedKombinacija
        {
            get => _selectedKombinacija;
            set
            {
                if (_selectedKombinacija != value)
                {


                    SetProperty(ref _selectedKombinacija, value);

                    OnKombinacijaSelected(value);
                }

            }
        }
  
        private async void OnKombinacijaDetalji(Item obj)
        {
            if (obj == null)
                return;


            // This will push the ItemDetailPage onto the navigation stack
            if (obj.KombinacijaId!=null )
            {
                await Shell.Current.GoToAsync($"{nameof(KombinacijaDetaljiPage)}?{nameof(KombinacijeDetaljiViewModel.KombinacijaId)}={obj.KombinacijaId.ToString()}");

            }

        }
      
        public async Task Naruci()
        {
            Singleton.UpdateProuzvodiListSvi(Kombinacije);
            await Shell.Current.GoToAsync(nameof(NarudzbaPage));
        }
        public async Task Init()
        {

            IsBusy = true;
            if (Singleton.ProizvodiListSvi.Count == 0 || Singleton.IsPonuda == false)
            {

                try
                {
                    KombinacijaSearchRequest r = new KombinacijaSearchRequest() { PonudaId=int.Parse(PonudaId) };
                    var list = await service.Get<List<Kombinacija>>(r);
                    Singleton.ProizvodiListSvi.Clear();
                    Singleton.SetPoizvodiListPonude(list);

                }
                catch (Exception)
                {

                    throw;
                }

            }

            Kombinacije.Clear();
            foreach (var item in Singleton.ProizvodiListSvi)
            {
                Kombinacije.Add(item);
            }
            IsBusy = false;
        }

    }
}
