using Equipe2_PneuStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace ApiPneuStore.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TyreController : ApiBaseController
    {
        ITyreService _service;

        public TyreController(ITyreService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());

        [HttpGet]
        [Route("{id}")]
        public IActionResult Index(int? id) => ApiOk(_service.Get(id));

    }
}
