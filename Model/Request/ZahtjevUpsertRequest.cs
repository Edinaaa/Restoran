using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class ZahtjevUpsertRequest
    {
        [DataType(DataType.Text),MaxLength(100)]
        public string Naziv { get; set; }
      
    }
}
