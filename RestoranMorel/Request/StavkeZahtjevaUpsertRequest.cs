using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
 public   class StavkeZahtjevaUpsertRequest
    {
        public int? ZahtjevId { get; set; }
        public int? KorisnikId { get; set; }
        public bool ZahtjevObradjen { get; set; }
  
    }
}
