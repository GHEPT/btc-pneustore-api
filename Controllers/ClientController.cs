using Equipe2_PneuStore.Controllers;
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
    public class ClientController : ApiBaseController
    {
        IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        /// <summary>
        /// Returns the list of customers registered in the database.
        /// Must be logged in and with valid token.
        /// </summary>
        /// <returns></returns>
        //Endpoint de acesso ao cadastro de todos os clientes
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet]
        [Authorize]
        public IActionResult Index() => ApiOk(_service.All());

        /// <summary>
        /// Returns the search customer according to the given id.
        /// Must be logged in and with valid token.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Endpoint de acesso ao cadastro de um cliente pelo id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Authorize]
        [Route("{id}")]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
            ApiNotFound("Cliente não encontrado.") :
            ApiOk(_service.Get(id));

        /// <summary>
        /// Sends the registration information of a new customer to the database.
        /// Must be logged in and with valid token.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        //Endpoint de cadastro de um novo cliente
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [AllowAnonymous]
        [HttpPost]        
        public IActionResult Create([FromBody] Client client)
        {
            return _service.Create(client) ?
               ApiOk(client, "Cadastro realizado com Sucesso.") :
               ApiNotFound("Erro ao cadastrar cliente.");
        }

        /// <summary>
        /// Sends a customer's update information to the database according to the customer entered.
        /// Must be logged in and with valid token.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        //Endpoint para atualização de um cliente
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPatch]
        [Authorize]
        public IActionResult Update([FromBody] Client client)
        {
            return _service.Update(client) ?
                ApiOk("Cadastro atualizado com sucesso.") :
                ApiNotFound("Erro ao atualizar cadastro.");
        }

        /// <summary>
        /// Deletes a customer from the database according to the given id.
        /// Must be logged in and with valid token.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Endpoint de exclusão de cadastro de um cliente pelo id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpDelete]
        [Authorize]
        [Route("{id}")]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Cadastro excluído com sucesso.") :
            ApiNotFound("Erro ao excluir cadastro.");

    }
}
