﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
  public  class StavkeMenia
    {
        public int StavkeMeniaId { get; set; }
        public int MeniId { get; set; }
        public Meni Meni { get; set; }
        public int ArtikalId { get; set; }
        public Artikal Artikal { get; set; }
        public double Popust { get; set; }
        public double Cijena { get; set; }
        public double CijenaSaPDV { get; set; }

        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
