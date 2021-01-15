using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
  public  class KorisniciUpsertReqests
    {

        [Required(AllowEmptyStrings = false)]

        public string Spol { get; set; }
        [Required(AllowEmptyStrings = false)]

        public DateTime DatumRodenja { get; set; }

        public DateTime? DatumZaposljavanja { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]


        public string KorisnickoIme { get; set; }
        public double IznosKredita { get; set; }


        public string Password { get; set; }
      
        public string PasswordPotvrda { get; set; }
        [Required(AllowEmptyStrings = false)]

        public List<int> Uloge { get; set; } = new List<int>();

        public byte[] Slika { get; set; }
    }
}
