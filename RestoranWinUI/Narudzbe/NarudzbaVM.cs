using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranWinUI.Narudzbe
{
   public class NarudzbaVM
    {
        public int NarudzbaId { get; set; }
        public bool Naplaceno { get; set; }
        public bool Odobrena { get; set; }

        public bool Odbijena { get; set; }
        public bool Naplati { get; set; }
        public double? Cijena { get; set; }
        public double? CijenaSaPdv { get; set; }
        public int BrojStola { get; set; }
        public string Narudzba { get; set; }



    }
}
