using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restoran.Database
{
   public class Kategorija
    {
       
        public int KategorijaId { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        [StringLength(20)]
        public string Naziv { get; set; }

    }
}
