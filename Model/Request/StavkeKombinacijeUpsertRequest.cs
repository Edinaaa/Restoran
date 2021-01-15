using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
 public   class StavkeKombinacijeUpsertRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KombinacijaId { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int ArtikalId { get; set; }
        [Range(0, float.MaxValue)]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Mozete unjeti broj za najvise 2 decimale.")]

        public float Kolicina { get; set; }
    }
}
