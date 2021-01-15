using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
  public  class PonudaSearchRequest
    {
        public int? KorisnikId { get; set; }
        public string DatumPocetka { get; set; }
        public string DatumZavrsetka { get; set; }
    }
}
