using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class KombinacijaUpsertRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]
        public int PonudaId { get; set; }
        [Range(0, double.MaxValue)]
      //  [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Mozete unjeti broj sa najvise 2 decimale.")]

        public double Cijena { get; set; }
        [Range(0, float.MaxValue)]

        public int PDV { get; set; }
        [Range(0, double.MaxValue)]
      //  [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Mozete unjeti broj sa najvise 2 decimale.")]

        public double CijenaSaPdv { get; set; }
        [Required(ErrorMessage = "Obavezno polje."), MaxLength(30)]

        public string Naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public byte[] Slika { get; set; }
        public List<StavkeKombinacije> Stavke { get; set; }
    }
}
