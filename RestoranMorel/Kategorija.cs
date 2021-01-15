using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
   public class Kategorija
    {
        public Kategorija() {
            StavkeMenias = new HashSet<StavkeMenia>();
        }
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public ICollection<StavkeMenia> StavkeMenias { get; set; }

    }
}
