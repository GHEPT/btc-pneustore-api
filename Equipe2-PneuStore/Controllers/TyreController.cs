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
    public class TyreController : ApiBaseController
    {
        ITyreService _service;

        public TyreController(ITyreService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna a lista com todos os pneus existentes no banco de dados.
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());

        /// <summary>
        /// Retorna um pneu específico de acordo com o id informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Authorize]
        [Route("{id}")]
        public IActionResult Index(int? id) => ApiOk(_service.Get(id));

    }
}
