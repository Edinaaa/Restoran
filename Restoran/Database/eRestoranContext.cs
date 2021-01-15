using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Restoran.Database { 
    public partial class eRestoranContext: DbContext
    {
        public eRestoranContext() { }
        public eRestoranContext(DbContextOptions<eRestoranContext> options): base(options) { }

        
        
        public virtual DbSet<Artikal> Artikli { get; set; }
        public virtual DbSet<JedinicaMjere> JedinicaMjeres { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual DbSet<Kombinacija> Kombinacijas { get; set; }

        public virtual DbSet<Uloge> Uloges { get; set; }
        public virtual DbSet<Meni> Menis { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<Ponuda> Ponudas { get; set; }
        public virtual DbSet<StavkaNarudzbe> StavkaNarudzbes { get; set; }
        public virtual DbSet<StavkeKombinacije> StavkeKombinacijes { get; set; }
        public virtual DbSet<StavkeMenia> StavkeMenias { get; set; }
        public virtual DbSet<StavkeZahtjeva> StavkeZahtjevas { get; set; }
        public virtual DbSet<Zahtjev> Zahtjevs { get; set; }
    }
}
