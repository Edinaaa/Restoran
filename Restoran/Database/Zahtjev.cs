using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restoran.Database
{
  public  class Zahtjev
    {
     
        public int ZahtjevId { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Naziv { get; set; }


    }
}
