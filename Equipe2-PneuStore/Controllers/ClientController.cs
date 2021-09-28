using ApiPneuStore.Controllers;
using Equipe2_PneuStore.Models;
using Equipe2_PneuStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Equipe2_PneuStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ApiBaseController
    {
        IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        //Endpoint de acesso ao cadastro de todos os clientes
        [HttpGet]
        [Authorize]
        public IActionResult Index() => ApiOk(_service.All());

        //Endpoint de acesso ao cadastro de um cliente pelo id
        [HttpGet]
        [Authorize]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
            ApiNotFound("Cliente não encontrado.") :
            ApiOk(_service.Get(id));

        //Endpoint de cadastro de um novo cliente
        [HttpPost]
        [Authorize]
        public IActionResult Create([FromBody] Client client)
        {
            return _service.Create(client) ?
               ApiOk("Cadastro realizado com sucesso.") :
               ApiNotFound("Erro ao cadasatrar cliente.");
        }

        //Endpoint para atualização de um cliente
        [HttpPut]
        [Authorize]
        public IActionResult Update([FromBody] Client client)
        {
            return _service.Update(client) ?
                ApiOk("Cadastro atualizado com sucesso.") :
                ApiNotFound("Erro ao atualizar cadastro.");
        }

        //Endpoint de exclusão de cadastro de um cliente pelo id
        [HttpDelete]
        [Authorize]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Cadastro excluído com sucesso.") :
            ApiNotFound("Erro ao excluir cadastro.");

    }
}
