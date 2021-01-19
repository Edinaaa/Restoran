using Restoran.Model;
using RestoranMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RestoranMobile.Helper
{
   public static class Singleton
    {

   

        public static ObservableCollection<Item> artikalMs { get; set; } = new ObservableCollection<Item>();
        public static bool IsPonuda { get; set; } = false;
        public static int IdKorisnika { get; set; }
      

        public static ObservableCollection<Item> ProizvodiListSvi { get; set; } = new ObservableCollection<Item>();
        public static ObservableCollection<Item> PreporukaList { get; set; } = new ObservableCollection<Item>();

        public static ObservableCollection<Item> SetPoizvodiList(List<StavkeMenija> lista) {
            IsPonuda = false;
            foreach (var proizvod in lista)
            {
                double popust = (proizvod.Popust * proizvod.Cijena)/ 100 ;
                double pdv = (proizvod.PDV * proizvod.Cijena) /100 ;
                ProizvodiListSvi.Add(new Item
                {
                    StavkeMenijaId = proizvod.StavkeMenijaId,
                    KombinacijaId=null,
                    Cijena = proizvod.Cijena-popust,
                    
                    CijenaSaPdv =( proizvod.Cijena - popust)+pdv,
                    PDV = proizvod.PDV,
                    Kolicina = 0,
                    KategorijaId = proizvod.KategorijaId,
                    Selected = false,
                    Naziv = proizvod.Artikal.Naziv,
                    Slika = proizvod.Artikal.Slika
                }); ;

                }
            return ProizvodiListSvi;
        }
        public static ObservableCollection<Item> SetPoizvodiListPonude(List<Kombinacija> lista)
        {
            IsPonuda = true;
            foreach (var proizvod in lista)
            {
                
                ProizvodiListSvi.Add(new Item
                {
                    KombinacijaId = proizvod.KombinacijaId,
                    StavkeMenijaId=null,
                    Cijena = proizvod.Cijena,
                    CijenaSaPdv = proizvod.CijenaSaPdv,
                    PDV = proizvod.PDV,
                    Kolicina = 0,
                    KategorijaId =0,
                    Selected = false,
                    Naziv = proizvod.Naziv,

                    Slika = proizvod.Slika
                });

            }
            return ProizvodiListSvi;
        }
        public static ObservableCollection<Item> SetPreporukaList(List<Preporuka> lista)
        {
         
            foreach (var proizvod in lista)
            {
                double popust = (proizvod.Popust * proizvod.Cijena) / 100;
                double pdv = (proizvod.PDV * proizvod.Cijena) / 100;
                PreporukaList.Add(new Item
                {
                    StavkeMenijaId = proizvod.StavkeMenijaId,
                    KombinacijaId = proizvod.KombinacijaId,
                    Cijena = proizvod.Cijena - popust,
                    CijenaSaPdv = (proizvod.Cijena - popust) + pdv,
                    PDV = proizvod.PDV,
                    Kolicina = 0,
                    KategorijaId = 0,
                    Selected = false,
                    Naziv = proizvod.Naziv,
                    Slika = proizvod.Slika
                }); ;

            }
            return PreporukaList;
        }

        public static ObservableCollection<Item> IzvrsenaPonistenaNarudba()
        {

            /*    foreach (var item in artikalMs)
                 {
                     Item i = ProizvodiListSvi.Where(x => (x.StavkeMeniaId == item.StavkeMeniaId && x.StavkeMeniaId != null)
                     || (x.KombinacijaId != null && x.KombinacijaId == item.KombinacijaId)).FirstOrDefault();
                     if (i!=null)
                     {
                         ProizvodiListSvi.Remove(i);

                         i.Kolicina = 0;
                         i.Selected = false;
                         ProizvodiListSvi.Add(i);
                     }
                 }*/
            PreporukaList.Clear();
            ProizvodiListSvi.Clear();
            artikalMs.Clear();
            /* 
            foreach (var item in ProizvodiListSvi)
            {
                if (item.Selected == true)
                {
                    item.Selected = false;
                    item.Kolicina = 0;
                   
                }
            }*/
            return ProizvodiListSvi;

        }

        public static void UpdateProuzvodiListSvi(ObservableCollection<Item> lista) {

            foreach (var item in ProizvodiListSvi)
            {
                foreach (var i in lista)
                {
                    if ( (i.KombinacijaId != null && i.KombinacijaId == item.KombinacijaId)|| (i.StavkeMenijaId != null && i.StavkeMenijaId == item.StavkeMenijaId))
                    {
                        Item a = artikalMs.Where(x => x.KombinacijaId == i.KombinacijaId && x.KombinacijaId!=null|| x.StavkeMenijaId == i.StavkeMenijaId && x.StavkeMenijaId!=null).FirstOrDefault();
                        if (i.Selected )
                        {
                            if (i.Kolicina!=0)
                            {
                                item.Kolicina = i.Kolicina;
                            }
                            if (a != null && i.Kolicina != 0)
                            {
                                artikalMs.Where(x => x.KombinacijaId == i.KombinacijaId && x.StavkeMenijaId == i.StavkeMenijaId).First().Kolicina = i.Kolicina;

                            }
                            else if (a == null)
                            {
                                artikalMs.Add(i);
                            }
                        }
                        else if (!i.Selected && a != null) {

                            artikalMs.Remove(i);
                        }
                            item.Selected = i.Selected;

                    }
                }
            }
          
        }
        public static void UpdatePreporuka( ObservableCollection<Item> preporuka)
        {

         
            foreach (var item in preporuka)
            {
                foreach (var pl in PreporukaList)
                {
                    if ((pl.KombinacijaId != null && pl.KombinacijaId == item.KombinacijaId) || (pl.StavkeMenijaId != null && pl.StavkeMenijaId == item.StavkeMenijaId))
                    {
                      
                        Item i = artikalMs.Where(x => x.KombinacijaId != null && x.KombinacijaId == item.KombinacijaId || x.StavkeMenijaId != null && x.StavkeMenijaId == item.StavkeMenijaId).FirstOrDefault();

                        if (item.Selected)
                        {
                           
                            if (item.Kolicina!=0)// ako se selektovani artikal pojavljuje i na preporuci i na meniu,
                            {                       //uzeti ce se vrijedonst koja je izmjenjena
                                pl.Kolicina = item.Kolicina;

                            }
                            if (i == null)
                            {
                                artikalMs.Add(item);
                            }
                            else if(i!=null && item.Kolicina!=0)
                            {
                                artikalMs.Remove(i);
                            
                                artikalMs.Add(item);
                            }
                        }
                        else 
                        {
                            if (i != null)
                                artikalMs.Remove(i);
                        }
                        pl.Selected = item.Selected;
                    }
                }
           
            }
        }
        public static ObservableCollection<Item> GetSelektovaneArtikle() 
        {
/*
            ObservableCollection<Item> selektovani = new ObservableCollection<Item>();
            foreach (var item in ProizvodiListSvi)
            {
                if (item.Selected==true)
                {
                    selektovani.Add(item);
                }
            }*/

            return artikalMs;
        
        }

        public static ObservableCollection<Item> GetArtiklePoKategoriji(int kategorijaId)
        {
            if (kategorijaId==7)
            {// sve id=7
                return ProizvodiListSvi;
            }
            ObservableCollection<Item> selektovani = new ObservableCollection<Item>();
            foreach (var item in ProizvodiListSvi)
            {
                if (item.KategorijaId == kategorijaId)
                {
                    selektovani.Add(item);
                }
            }
            return selektovani;

        }
        public static ObservableCollection<Item> GetArtiklePoNazivu(string naziv)
        {

            ObservableCollection<Item> selektovani = new ObservableCollection<Item>();
            foreach (var item in ProizvodiListSvi)
            {
                if (item.Naziv == naziv)
                {
                    selektovani.Add(item);
                }
            }
            return selektovani;

        }


    }
}
