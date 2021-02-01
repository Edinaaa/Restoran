using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restoran.Database
{
   public class JedinicaMjere
    {
     
        public int JedinicaMjereId { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings =false)]
        [StringLength(15)]
        [Index(IsUnique = true)]
        public string Naziv { get; set; }

    }
}
