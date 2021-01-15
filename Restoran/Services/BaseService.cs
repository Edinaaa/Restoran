using AutoMapper;
using Restoran.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class BaseService<TModel, Tsearch, TDatabase> : IService<TModel, Tsearch> where TDatabase : class
    {
        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        public BaseService(eRestoranContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(Tsearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
