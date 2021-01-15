using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
  public  class KorisniciUpsertReqests
    {

        [Required(ErrorMessage = "Obavezno polje."), MaxLength(1)]//M ili Z
        [RegularExpression(@"^[M|Z]{1}$", ErrorMessage = "Mozete unjeti M kao oznaku za musko, i Z kao oznaku za zensko.")]

        public string Spol { get; set; }
        [Required(ErrorMessage = "Obavezno polje.",AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DatumRodenja { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]

        public DateTime? DatumZaposljavanja { get; set; }

        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false), MaxLength(30)]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false), MaxLength(30)]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false), MaxLength(30)]


        public string KorisnickoIme { get; set; }
        [Range(0,double.MaxValue)]
        public double IznosKredita { get; set; }

        public byte[] Slika { get; set; }
        [DataType(DataType.Password), MaxLength(50)]

        public string Password { get; set; }
        [DataType(DataType.Password), MaxLength(50)]

        public string PasswordPotvrda { get; set; }
        [Required(AllowEmptyStrings = false)]

        public List<int> Uloge { get; set; } = new List<int>();

    
    }
}
