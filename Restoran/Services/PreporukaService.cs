using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class PreporukaService : IPreporukaService
    {

        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        public PreporukaService(eRestoranContext context, IMapper mapper) { _context = context; _mapper = mapper; }
        List<Preporuka> proizvodiPosmatranog;
        int idKorisnika;
        double najvecaSlicnost=0.3;
        List<Preporuka> preporuceni = new List<Preporuka>();
    /* private List<Preporuka> GetSlicniog() {
             var ostaliKorisnici = _context.Korisniks.Where(x=>x.KorisnikId!=idKorisnika).ToList();
             List<Preporuka> preporuceni = new List<Preporuka>();
             proizvodiPosmatranog = SetBrojNarudzbiKorisnika(idKorisnika);


             foreach (var item in ostaliKorisnici)
             {
                 List<Preporuka> proizvodiDrugih = SetBrojNarudzbiKorisnika(item.KorisnikId);

                 double Slicnost = GetSlicnost(proizvodiDrugih);
                 if (Slicnost>najvecaSlicnost)
                 {
                     najvecaSlicnost = Slicnost;
                     preporuceni = proizvodiDrugih;
                 }
             }

             return preporuceni;
         }
*/ 
        private void SetPreporuke()
        {
            var ostaliKorisnici = _context.Korisniks.Where(x => x.KorisnikId != idKorisnika).ToList();
           
            proizvodiPosmatranog = SetBrojNarudzbiKorisnika(idKorisnika);


            foreach (var item in ostaliKorisnici)
            {
                List<Preporuka> proizvodiDrugih = SetBrojNarudzbiKorisnika(item.KorisnikId);

                double Slicnost = GetSlicnost(proizvodiDrugih);
                if (Slicnost > najvecaSlicnost)
                {
                    //ako je korisnok slican na listu preporuceni dodje sve koji povecavanju sliscnost
                   GetPreporukaList(proizvodiDrugih,Slicnost);
                }
            }

         
        }
    /*    private Preporuka GetPreporuka() {
            List<Preporuka> proizvodiDrugog = GetSlicniog();
            Preporuka najslicniji=new Preporuka();
            double vecaSlicnost = najvecaSlicnost;
            foreach (var item in proizvodiPosmatranog)
            {
               
                item.brojNarudzbi++;
                double Slicnost = -1;
                Slicnost = GetSlicnost(proizvodiDrugog);
                if (Slicnost>vecaSlicnost)
                {
                    vecaSlicnost = Slicnost;
                    najslicniji = item;
                }
                item.brojNarudzbi--;
            }
            return najslicniji;
        }*/
        private void GetPreporukaList(List<Preporuka> proizvodiDrugog, double Slicnost)
        {

            foreach (var item in proizvodiPosmatranog)
            {

                item.brojNarudzbi++;
                double slicnost = -1;
                slicnost = GetSlicnost(proizvodiDrugog);
                if (slicnost > Slicnost && preporuceni
                    .Where(x=>(x.KombinacijaId!=null && x.KombinacijaId == item.KombinacijaId)
                            ||(x.StavkeMenijaId!=null && x.StavkeMenijaId==item.StavkeMenijaId)
                     ).Count()==0
                   )
                {
                    preporuceni.Add(item);
                }
                item.brojNarudzbi--;
            }
        }

        private double GetSlicnost(List<Preporuka> proizvodiDrugih)
        {
            double slicnost = -1;
           double prosjekDrugih=Math.Round( proizvodiDrugih.Average(x => x.brojNarudzbi),9);
            double prosjekposmatranog =Math.Round( proizvodiPosmatranog.Average(x => x.brojNarudzbi),9);
            double brojnik = 0;
            double nazivnik1 = 0;
            double nazivnik2 = 0;
            foreach (var item in proizvodiPosmatranog)
            {
                foreach (var x in proizvodiDrugih)
                {
                    if ((item.KombinacijaId==x.KombinacijaId && item.KombinacijaId!=null) || (item.StavkeMenijaId == x.StavkeMenijaId && item.StavkeMenijaId != null))
                    {
                        double b = Math.Round((item.brojNarudzbi - prosjekposmatranog) * (x.brojNarudzbi - prosjekDrugih), 9);
                        double n1 = Math.Round(Math.Pow(item.brojNarudzbi - prosjekposmatranog, 2), 9);
                        double n2 = Math.Round(Math.Pow(x.brojNarudzbi - prosjekDrugih, 2), 9);
                        brojnik += b;
                        nazivnik1 += n1;
                        nazivnik2 += n2;
                    }
            
                }
            }
            if (brojnik==0)
            {
                return slicnost;
            }
            double nazivnik = (Math.Sqrt(nazivnik1) * Math.Sqrt(nazivnik2));
            slicnost = brojnik /nazivnik;
         return   slicnost;
        }

        private List<Preporuka> SetBrojNarudzbiKorisnika(int idKorisnika)
        {
            var stavkenarudzbe = _context.StavkaNarudzbes.Where(x => x.Narudzba.KorisnikId == idKorisnika ).Include(x=>x.Kombinacija).Include(x=>x.StavkeMenia).ToList();
            List<Preporuka> preporukak = new List<Preporuka>();
            List<Preporuka> preporukam = new List<Preporuka>();

            preporukam =_mapper.Map<List<Model.Preporuka>>(_context.StavkeMenias.Include(x=>x.Artikal).ToList().OrderBy(x => x.StavkeMenijaId));
            preporukak= _mapper.Map<List< Model.Preporuka>>(_context.Kombinacijas.ToList().OrderBy(x=>x.KombinacijaId)); ;
         
           
                foreach (var x in stavkenarudzbe)
                {
                    if (x.StavkeMenijaId!=null && preporukam.Where(p => p.StavkeMenijaId == x.StavkeMenijaId).Count()>0)
                    {
                        preporukam.Where(p => p.StavkeMenijaId ==x.StavkeMenijaId).FirstOrDefault().brojNarudzbi += 1;
                    }
                }
           


                foreach (var x in stavkenarudzbe)
                {
             
                    if (x.KombinacijaId != null && preporukak.Where(p => p.KombinacijaId == x.KombinacijaId).Count() > 0)
                        {
                             preporukak.Where(p => p.KombinacijaId == x.KombinacijaId).FirstOrDefault().brojNarudzbi += 1;

                        }
                }
            foreach (var item in preporukak)
            {
                preporukam.Add(item);
            }
            List<int> lista = new List<int>();

            foreach (var item in preporukam)
            {
                lista.Add(item.brojNarudzbi);
            }
          
            return preporukam;
        
        }
    /*   private void SetBrojNarudzbiKorisnika(int idKorisnika, ref Dictionary<Database.StavkeMenia, int> brojNarudzbiStavkeMenia, ref Dictionary<Database.Kombinacija, int> brojNarudzbiKombinacije)
        {
            var stavkenarudzbe = _context.StavkaNarudzbes.Where(x => x.Narudzba.KorisnikId == idKorisnika).ToList();
            var stavkemenia = _context.StavkeMenias.ToList();
            var kombinacije = _context.Kombinacijas.ToList();

            foreach (var item in stavkemenia)
            {
                int broj = 0;
                foreach (var x in stavkenarudzbe)
                {
                    if (x.StavkeMeniaId != null)
                    {
                        if (x.StavkeMeniaId == item.StavkeMeniaId)
                        {
                            broj++;
                        }
                    }
                }
                brojNarudzbiStavkeMenia.Add(item, broj);
            }
            foreach (var item in kombinacije)
            {
                int broj = 0;
                foreach (var x in stavkenarudzbe)
                {
                    if (x.KombinacijaId != null)
                    {
                        if (x.KombinacijaId == item.KombinacijaId)
                        {
                            broj++;
                        }
                    }
                }
                brojNarudzbiKombinacije.Add(item, broj);
            }
        }
       */  
        public List<Model.Preporuka> Get(PreporukaSerachRequest request)
        {
            idKorisnika = request.KorisnikId;
            SetPreporuke();
            return preporuceni;
        }
    }
}
