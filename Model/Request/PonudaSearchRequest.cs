using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
  public  class PonudaSearchRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int? KorisnikId { get; set; }
        [DataType(DataType.Date)]

        public string DatumPocetka { get; set; }
        [DataType(DataType.Date)]

        public string DatumZavrsetka { get; set; }
    }
}
