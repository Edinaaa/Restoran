using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class MeniSearchRequest
    {
        [DataType(DataType.Text), MaxLength(30)]

        public string Naziv { get; set; }

        public bool Vazeci { get; set; }
        public bool NeVazeci { get; set; }


    }
}
