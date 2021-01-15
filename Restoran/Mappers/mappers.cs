using AutoMapper;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Mappers
{
    public class mappers : Profile
    {
        public mappers()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik, KorisniciUpsertReqests>().ReverseMap();
            CreateMap<Database.Narudzba, Model.Narudzba>();
            CreateMap<Database.Narudzba, NarudzbaUpsertRequest>().ReverseMap();
            CreateMap<Database.Artikal, Model.Artikal>();
            CreateMap<Database.Artikal, ArtikalUpsertRequest>().ReverseMap();
            CreateMap<Database.JedinicaMjere, Model.JedinicaMjere>();
            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.Ponuda, Model.Ponuda>();
            CreateMap<Database.Ponuda, PonudaUpsertRequest>().ReverseMap();
            CreateMap<Database.Kombinacija, Model.Kombinacija>();
            CreateMap<Database.Kombinacija, KombinacijaUpsertRequest>().ReverseMap();
            //CreateMap<Database.JedinicaMjere, JedinicaMjereUpsertRequest>().ReverseMap();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.KorisnikUloga, Model.KorisnikUloga>();
            CreateMap<Database.Ponuda, Model.Ponuda>();
            CreateMap<Database.Meni, Model.Meni>();
            CreateMap<Database.Meni, MeniUpsertRequest>().ReverseMap();

            CreateMap<Database.Zahtjev, Model.Zahtjev>();
            CreateMap<Database.Zahtjev, ZahtjevUpsertRequest>().ReverseMap();
          
            CreateMap<Database.StavkeMenia, Model.StavkeMenia>().ReverseMap();
            CreateMap<Database.StavkeMenia, StavkeMeniaUpsertRequest>().ReverseMap();

            CreateMap<Database.StavkeKombinacije, Model.StavkeKombinacije>();
            CreateMap<Database.StavkeKombinacije, StavkeKombinacijeUpsertRequest>().ReverseMap();

            CreateMap<Database.StavkaNarudzbe, Model.StavkaNarudzbe>();
            CreateMap<Database.StavkaNarudzbe, StavkeNarudzbeUpsertRequest>().ReverseMap();


            CreateMap<Database.StavkeZahtjeva, Model.StavkeZahtjeva>();
            CreateMap<Database.StavkeZahtjeva, StavkeZahtjevaUpsertRequest>().ReverseMap();




            CreateMap<Database.StavkeMenia, Model.Preporuka>()
                .ForMember(dest => dest.Slika, opt => opt.MapFrom(src => src.Artikal.Slika))
                .ForMember(dest => dest.Sastav, opt => opt.MapFrom(src => src.Artikal.Sastav))
                .ForMember(dest => dest.Naziv, opt => opt.MapFrom(src => src.Artikal.Naziv)); 
            CreateMap<Database.Kombinacija, Model.Preporuka>();



        }
    }
}
