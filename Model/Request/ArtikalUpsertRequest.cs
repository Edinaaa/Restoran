using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
  public  class ArtikalUpsertRequest
    {
       // [Required(ErrorMessage ="Obavezno polje.", AllowEmptyStrings =false), DataType(DataType.Text), MaxLength(30)]

        public string Naziv { get; set; }
  //      [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
        public double Cijena { get; set; }
      //  [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]

        public int Popust { get; set; }
    //    [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]

        public int PDV { get; set; }
  //      [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]

        public string Sastav { get; set; }
      //  [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]

        public double CijenaSaPdv { get; set; }
       // [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
       // [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]
        public int JedinicaMjereId { get; set; }
      //  [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
     //   [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KategorijaId { get; set; }
       // [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]
      //  [Range(1, 1000, ErrorMessage = "Kolicina ne moze biti veca od 1000.")]
      //  [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage ="Mozete unjeti broj za najvise 2 decimale.")]
        public float Kolicina { get; set; }// korisnik moze unjeti kolicinu 700g, ako zeli unjeti 1200 g
                                           //promjeniti ce jedinicu mjere
      //  [Required(ErrorMessage = "Obavezno polje.", AllowEmptyStrings = false)]

        public byte[] Slika { get; set; }
    }
}
