using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppGaragem.Models;
using WebAppGaragem.Repositorios.Interfaces;

namespace WebAppGaragem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagemController : ControllerBase
    {
        private readonly IPassagemRepositorio _passagemRepositorio;
        public PassagemController(IPassagemRepositorio passagemRepositorio)
        {
            _passagemRepositorio = passagemRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PassagemModel>>> BuscarTodasPassagens()
        {
            List<PassagemModel> passagens = await _passagemRepositorio.BuscarTodasPassagens();
            return Ok(passagens);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PassagemModel>> BuscarPorId(int id)
        {
            PassagemModel passagem = await _passagemRepositorio.BuscarPorId(id);
            return Ok(passagem);
        }

        [HttpPost]
        public async Task<ActionResult<PassagemModel>> Cadastrar([FromBody] PassagemModel passagemModel)
        {
            PassagemModel passagem = await _passagemRepositorio.Adicionar(passagemModel);
            return Ok(passagem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PassagemModel>> Atualizar([FromBody] PassagemModel passagemModel, int id)
        {
            passagemModel.Id = id;
            PassagemModel passagem = await _passagemRepositorio.Atualizar(passagemModel, id);
            return Ok(passagem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PassagemModel>> Apagar(int id)
        {
            bool apagado = await _passagemRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
