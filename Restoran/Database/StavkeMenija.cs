
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Database
{
  public  class StavkeMenija
    {
        public int StavkeMenijaId { get; set; }
        public int MeniId { get; set; }
        public Meni Meni { get; set; }
        public int ArtikalId { get; set; }
        public Artikal Artikal { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public int Popust { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public double Cijena { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public int PDV { get; set; }
        public bool Aktivan { get; set; }

        [Required(ErrorMessage = "Obavezno polje.")]

        public double CijenaSaPDV { get; set; }

        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
