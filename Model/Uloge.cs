using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Model
{
    public class Uloge
    {
        public Uloge() {
            KorisnikUlogas = new HashSet<KorisnikUloga>();
        }
        public int UlogeId { get; set; }
        public string Naziv { get; set; }
        public ICollection<KorisnikUloga> KorisnikUlogas { get; set; }

    }
}
