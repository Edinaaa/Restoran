using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Restoran.Model
{
  public  class StavkeZahtjeva
    {
        public int StavkeZahtjevaId { get; set; }
        public bool ZahtjevObradjen { get; set; }

        public int KorisnikId { get; set; }
        public int ZahtjevId { get; set; }
        public Zahtjev Zahtjev { get; set; }
    }
}
