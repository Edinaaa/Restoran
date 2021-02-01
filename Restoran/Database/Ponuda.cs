using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace Restoran.Database
{
   public class Ponuda
    {
        public int PonudaId { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

        public DateTime DatumPocetka { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

        public DateTime DatumZavrsetka { get; set; }


    }
}
