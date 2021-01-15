using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
 public   class StavkeZahtjevaUpsertRequest
    {
        public int? ZahtjevId { get; set; }
        public bool ZahtjevObradjen { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KorisnikId { get; set; }

    }
}
