using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace RestoranMobile.Models
{
   public class Item: BaseModel
    {
        public int? KombinacijaId { get; set; }
        public int? StavkeMenijaId { get; set; }

        public string Naziv { get; set; }
        public double Cijena { get; set; }
      
        public byte[] Slika { get; set; }

      


        public int? KategorijaId { get; set; }

        public double CijenaSaPdv { get; set; }
        public int PDV { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Mozete unjeti broj za najvise 2 decimale.")]
        [Range(0,50, ErrorMessage ="Ne mozete naruciti vise od 50 artikala  u jednoj narudzbi.")]
        private float _kolicina;
              
        public float Kolicina { 
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); } }
        private bool _Selected;

        public bool Selected
        {
            get { return _Selected; }
            set { SetProperty(ref _Selected, value); }
        }
    }
}
