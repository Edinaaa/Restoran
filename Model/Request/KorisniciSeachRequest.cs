using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
    public class KorisniciSeachRequest
    {
        [DataType(DataType.Text),MaxLength(30)]
        public string Ime { get; set; }
        [DataType(DataType.Text),MaxLength(30)]
        public string Prezime { get; set; }
        [DataType(DataType.Text),MaxLength(30)]
        public string KorisnickoIme { get; set; }
        [DataType(DataType.Password), MaxLength(50)]

        public string Password { get; set; }
        [DataType(DataType.Text), MaxLength(30)]

        public string Uloga { get; set; }
        public bool NajCasci { get; set; }



    }
}
