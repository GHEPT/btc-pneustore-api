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
    public class AddressController : ApiBaseController
    {
        IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;                
        }

        /// <summary>
        /// Returns a list of addresses registered in the database.
        /// </summary>
        /// <returns></returns>
        //Endpoint de acesso aos cadastros de endereços
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet]        
        public IActionResult Index() => ApiOk(_service.All());

        /// <summary>
        /// Returns an address registered in the database according to the entered id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Endpoint de acesso ao cadastro de um endereço pelo id
        [HttpGet]        
        [Route("{id}")]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
            ApiNotFound("Endereço não encontrado.") :
            ApiOk(_service.Get(id));

        /// <summary>
        /// Sends the registration information of a new address to the database.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        //Endpoint de cadastro de um novo endereço
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost]
        [Authorize]
        public IActionResult Create([FromBody] Address address)
        {
            return _service.Create(address) ?
               ApiOk(address, "Endereço registrado com Sucesso") :
               ApiNotFound("Erro ao registrar endereço.");
        }

        /// <summary>
        /// Sends an address update information to the database according to the address entered.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        //Endpoint para atualização de um endereço
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPut]
        [Authorize]
        public IActionResult Update([FromBody] Address address)
        {
            return _service.Update(address) ?
                ApiOk("Endereço atualizado com sucesso.") :
                ApiNotFound("Erro ao atualizar endereço.");
        }

        /// <summary>
        /// Deletes an address from the database according to the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Endpoint de exclusão de um endereço pelo id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpDelete]
        [Authorize]
        [Route("{id}")]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Endereço excluído com sucesso.") :
            ApiNotFound("Erro ao excluir endereço.");
    }
}
