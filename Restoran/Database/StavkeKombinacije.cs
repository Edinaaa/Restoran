﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Database
{
  public  class StavkeKombinacije
    {

        public StavkeKombinacije()
        {
        
        }

        public int StavkeKombinacijeId { get; set; }
        public int KombinacijaId { get; set; }
        public Kombinacija Kombinacija { get; set; }
        public int ArtikalId { get; set; }
        public Artikal Artikal { get; set; }
        public float Kolicina { get; set; }
    }
}
