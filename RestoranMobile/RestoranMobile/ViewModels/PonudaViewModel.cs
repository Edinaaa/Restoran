using Restoran.Model;
using RestoranMobile.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
    public   class PonudaViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("Ponuda");
        public ObservableCollection<Ponuda> Ponude { get; set; } = new ObservableCollection<Ponuda>();

        public Command<Ponuda> PonudaTapped { get; }
        public ICommand PonudeCommand { get; set; }

        public void OnAppearing()
        {
            IsBusy = true;


        }


        public PonudaViewModel() {

            Title = "Ponude";
            PonudeCommand = new Command(async ()=> await SetPonude());
            PonudaTapped = new Command<Ponuda>(OnTapped);
        }

        private async void OnTapped(Ponuda obj)
        {
            if (obj == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(KombinacijePonudePage)}?{nameof(KombinacijePonudeViewModel.PonudaId)}={obj.PonudaId}");

        }


        public async Task SetPonude()
        {
            var list =await service.Get<List<Ponuda>>(null);
            Ponude.Clear();
            foreach (var item in list)
            {
                Ponude.Add(item);
            }
           
        }
    }
}
