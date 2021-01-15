using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
    public class MeniUpsertRequest
    {
        public int KorisnikId { get; set; }
        public string Naziv { get; set; }
        public bool Vazeci { get; set; }
        public List<int> Stavke { get; set; }

    }
}
