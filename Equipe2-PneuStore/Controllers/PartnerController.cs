using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace ApiPneuStore.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PartnerController : ApiBaseController
    {
        //IPartnerService _service;

        //public PartnerController(IPartnerService service)
        //{
        //    _service = service;
        //}

        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());

        [HttpGet]
        [Route("{id}")]
        public IActionResult Index(int? id) => ApiOk(_service.Get(id));
    }
}
