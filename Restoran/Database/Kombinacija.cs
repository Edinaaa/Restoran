using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Database
{
  public  class Kombinacija
    {
        public int KombinacijaId { get; set; }
        public int PonudaId { get; set; }
        public Ponuda Ponuda { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public double Cijena { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public int PDV { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public double CijenaSaPdv { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Obavezno polje.")]

        public string Naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public byte[] Slika { get; set; }

    }
}
