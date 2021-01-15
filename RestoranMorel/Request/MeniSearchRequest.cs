using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
   public class MeniSearchRequest
    {
        public string Naziv { get; set; }
        public bool Vazeci { get; set; }
        public bool NeVazeci { get; set; }


    }
}
