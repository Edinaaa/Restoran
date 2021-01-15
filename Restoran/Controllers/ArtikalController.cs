using Restoran.Model;
using Restoran.Services;
using Restoran.Model.Request;
using System.Web.Http;
using Microsoft.AspNetCore.Components;

namespace Restoran.Controllers
{
   
    [Route("api/[controller]")]
    //[ApiController]
    public class ArtikalController : BaseCRUDController<Artikal, ArtikalSearchRequest, ArtikalUpsertRequest, ArtikalUpsertRequest>
    {
        public ArtikalController(ICRUDService<Artikal, ArtikalSearchRequest, ArtikalUpsertRequest, ArtikalUpsertRequest> service) : base(service)
        {
        }
    }
}
