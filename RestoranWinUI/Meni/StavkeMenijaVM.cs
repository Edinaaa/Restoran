using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranWinUI.Meni
{
   public class StavkeMenijaVM
    {
        public int StavkeMenijaId { get; set; }
        public int MeniId { get; set; }
        public int ArtikalId { get; set; }
        public bool Aktivan { get; set; }

        public string Kategorija { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public int Popust { get; set; }
        public double Cijena { get; set; }
        public double CijenaSaPDV { get; set; }
        public int PDV { get; set; }



    }
}
