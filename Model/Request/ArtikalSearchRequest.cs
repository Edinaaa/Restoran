using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
  public  class ArtikalSearchRequest
    {
        public List<int> id_artikals { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KategorijaId { get; set; }
        [DataType(DataType.Text),MaxLength(30)]

        public string  Naziv { get; set; }
    }
}
