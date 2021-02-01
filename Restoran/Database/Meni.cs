using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Database
{
   public class Meni
    {
    
        public int MeniId { get; set; }

        public int KorisnikId { get; set; }
        public Korisnik Konobar { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DatumObjave { get; set; }
        public bool Vazeci { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        public string Naziv { get; set; }


    }
}
