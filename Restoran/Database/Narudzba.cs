using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Database
{
   public class Narudzba
    {
     
        public int NarudzbaId { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

        public DateTime DatumNarudzbe { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public bool PlacanjeKreditima { get; set; }
        public bool Naplaceno { get; set; }
        public bool Odobrena { get; set; }
        public bool Odbijena { get; set; }
        public bool Naplati { get; set; }
        public double? Cijena { get; set; }
        public double? CijenaSaPdv { get; set; }
        public float? Pdv { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public int BrojStola { get; set; }



    }
}
