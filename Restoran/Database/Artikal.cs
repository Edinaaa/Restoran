using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Database
{
   public class Artikal
    {
      
        public int ArtikalId { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public double Cijena { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public int Popust { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public int PDV { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        public string Sastav { get; set; }
        [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        public byte[] Slika { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public double CijenaSaPdv { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public int JedinicaMjereId { get; set; }
        public JedinicaMjere JedinicaMjere { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public float Kolicina { get; set; }



    }
}
