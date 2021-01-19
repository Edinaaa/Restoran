using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class StavkeMenijaService : BaseCRUDService<Model.StavkeMenija, StavkeMenijaSearchRequest, Database.StavkeMenija, object, object>
    {
        public StavkeMenijaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.StavkeMenija> Get(StavkeMenijaSearchRequest search)
        {
            var stavke = _context.StavkeMenias.Where(x=>x.MeniId==search.MeniId).Include(x=>x.Artikal).Include(x=>x.Kategorija).ToList();
           return _mapper.Map<List<Model.StavkeMenija>>(stavke);
        }
     
        public override Model.StavkeMenija GetById(int id)
        {
            var entity = _context.StavkeMenias.Include(x => x.Artikal).Include(x => x.Kategorija).Where(x => x.StavkeMenijaId == id).FirstOrDefault();
            return _mapper.Map<Model.StavkeMenija>(entity);
        }
      
    }
}
