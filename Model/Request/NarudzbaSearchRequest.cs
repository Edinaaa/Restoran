using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class NarudzbaSearchRequest
    {
        [DataType(DataType.Date)]
        public DateTime DatumNarudzbe { get; set; }

        public bool PretragaPoDatumu { get; set; }
        public int KorisnikId { get; set; }

    }
}
