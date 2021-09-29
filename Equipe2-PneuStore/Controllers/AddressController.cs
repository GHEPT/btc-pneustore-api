using ApiPneuStore.Controllers;
using Equipe2_PneuStore.Models;
using Equipe2_PneuStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Equipe2_PneuStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ApiBaseController
    {
        IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;                
        }

        //Endpoint de acesso aos cadastros de endereços
        [HttpGet]
        [Authorize]
        public IActionResult Index() => ApiOk(_service.All());

        //Endpoint de acesso ao cadastro de um endereço pelo id
        [HttpGet]
        [Authorize]
        [Route("{id}")]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
            ApiNotFound("Endereço não encontrado.") :
            ApiOk(_service.Get(id));

        //Endpoint de cadastro de um novo endereço
        [HttpPost]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Create([FromBody] Address address)
        {
            return _service.Create(address) ?
               ApiOk(address, "Endereço registrado com Sucesso") :
               ApiNotFound("Erro ao registrar endereço.");
        }

        //Endpoint para atualização de um endereço
        [HttpPut]
        [Authorize]
        public IActionResult Update([FromBody] Address address)
        {
            return _service.Update(address) ?
                ApiOk("Endereço atualizado com sucesso.") :
                ApiNotFound("Erro ao atualizar endereço.");
        }

        //Endpoint de exclusão de um endereço pelo id
        [HttpDelete]
        [Authorize]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Endereço excluído com sucesso.") :
            ApiNotFound("Erro ao excluir endereço.");
    }
}
