using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class PonudaUpsertRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KorisnikId { get; set; }
        [DataType(DataType.Date)]

        public DateTime DatumPocetka { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]

        public DateTime DatumZavrsetka { get; set; } = DateTime.Now;
        public List<int> Kombinacije { get; set; }
    }
}
