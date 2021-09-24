using Equipe2_PneuStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiPneuStore.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("[controller]")]
    public class PartnerController : ApiBaseController
    {
        IPartnerService _service;

        public PartnerController(IPartnerService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna a lista de parceiros cadastrados no banco de dados.
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());

        /// <summary>
        /// Retorna um parceiro cadastrado de acordo com o id informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize]
        [HttpGet]
        [Route("{id}")]
        public IActionResult Index(int? id) => ApiOk(_service.Get(id));
    }
}
