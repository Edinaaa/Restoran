using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Database
{
    public class Uloge
    {
      
        public int UlogeId { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        [StringLength(15)]
        public string Naziv { get; set; }

    }
}
