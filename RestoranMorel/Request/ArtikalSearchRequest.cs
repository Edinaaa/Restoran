using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
  public  class ArtikalSearchRequest
    {
        public List<int> id_artikals { get; set; }
        public int KategorijaId { get; set; }
        public string  Naziv { get; set; }
    }
}
