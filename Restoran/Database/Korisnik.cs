using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restoran.Database
{
    public class Korisnik
    {
      
        public int KorisnikId { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Obavezno polje.")]

        public string Ime { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Obavezno polje.")]

        public string Prezime { get; set; }
        [Required(ErrorMessage = "Obavezno polje."), MaxLength(1)]//M ili Z
        [RegularExpression(@"^[M|Z]{1}$", ErrorMessage = "Mozete unjeti M kao oznaku za musko, i Z kao oznaku za zensko.")]
        public string Spol { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

        public DateTime DatumRodenja { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]

        public DateTime? DatumZaposljavanja { get; set; }
        public double IznosKredita { get; set; }
        [StringLength(30)]
        public string KorisnickoIme { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public string LozinkaSalt { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public string LozinkaHesh { get; set; }

        [Required(ErrorMessage = "Obavezno polje.")]


        public byte[] Slika { get; set; }


    }
}
