using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
    public class KorisniciSeachRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string Uloga { get; set; }


    }
}
