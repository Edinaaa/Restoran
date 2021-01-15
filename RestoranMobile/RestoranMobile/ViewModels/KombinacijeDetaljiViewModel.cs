using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestoranMobile.ViewModels
{
    [QueryProperty(nameof(KombinacijaId), nameof(KombinacijaId))]


    class KombinacijeDetaljiViewModel : BaseViewModel
    {
        private string kombinacijaId;
        public string KombinacijaId {
            get { return kombinacijaId; }
            set { SetProperty(ref kombinacijaId, value);
                OnSetKombinacijaID(value);
            }

        }
        private Kombinacija kombinacija;
        public Kombinacija Kombinacija
        {
            get { return kombinacija; }
            set
            {
                SetProperty(ref kombinacija, value);
            }

        }

        public ICommand StavkeKombinacijeCommand { get; set; }

        public void OnAppearing()
        {
            IsBusy = true;
        }
        private readonly APIService service = new APIService("Kombinacija");
        private readonly APIService serviceStavke = new APIService("StavkeKombinacije");
        public ObservableCollection<StavkeKombinacije> StavkeKombinacije { get; set; } = new ObservableCollection<StavkeKombinacije>();


        public KombinacijeDetaljiViewModel() {
            Title = "Detalji kombinacije";
           StavkeKombinacijeCommand = new Command(async () => await SetStavke());


        }

        private async Task SetStavke()
        {
            StavkeKombinacijeSearchRequest request = new StavkeKombinacijeSearchRequest() { KombinacijaId = int.Parse(KombinacijaId)};
            var list = await serviceStavke.Get<List<StavkeKombinacije>>(request);
            StavkeKombinacije.Clear();
            foreach (var item in list)
            {
                StavkeKombinacije.Add(item);
            }

            IsBusy = false;

        }

        private async void OnSetKombinacijaID( string value) {

            int id = int.Parse( value);
            Kombinacija = await service.GetById<Kombinacija>(id);

        }
    }
}
