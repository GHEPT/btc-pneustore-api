using Equipe2_PneuStore.Models;
using Equipe2_PneuStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Equipe2_PneuStore.Controllers
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
        /// Returns the list of all tires in the database.
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]       
        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());

        /// <summary>
        /// Returns a specific tire according to the id entered.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]        
        [Route("{id}")]
        public IActionResult Index(int? id) => ApiOk(_service.Get(id));

        /// <summary>
        /// Sends the registration information of a new tyre to the database.
        /// </summary>
        /// <param name="tyre"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Create([FromBody] Tyre tyre)
        {
            return _service.Create(tyre) ?
               ApiOk(tyre, "Cadastro realizado com Sucesso.") :
               ApiNotFound("Erro ao cadastrar pneu.");
        }
    }
}
