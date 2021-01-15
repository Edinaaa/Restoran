using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
    public class MeniUpsertRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KorisnikId { get; set; }
        [DataType(DataType.Text), MaxLength(30)]
[Required(AllowEmptyStrings =false,ErrorMessage ="Obavezno polje.")]
        public string Naziv { get; set; }

        public bool Vazeci { get; set; }
        public List<StavkeMenia> Stavke { get; set; }

    }
}
