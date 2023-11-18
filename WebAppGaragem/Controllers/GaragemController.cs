using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppGaragem.Models;
using WebAppGaragem.Repositorios;
using WebAppGaragem.Repositorios.Interfaces;

namespace WebAppGaragem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragemController : ControllerBase
    {
        private readonly IGaragemRepositorio _garagemRepositorio;
        public GaragemController(IGaragemRepositorio garagemRepositorio)
        {
            _garagemRepositorio = garagemRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<GaragemModel>>> BuscarTodasGaragens()
        {
            List<GaragemModel> garagens = await _garagemRepositorio.BuscarTodasGaragens();
            return Ok(garagens);
        }

        [HttpGet("{codigo}")]
        public async Task<ActionResult<GaragemModel>> BuscarPorCodigo(string codigo)
        {
            GaragemModel garagem = await _garagemRepositorio.BuscarPorCodigo(codigo);
            return Ok(garagem);
        }

        [HttpPost]
        public async Task<ActionResult<GaragemModel>> Cadastrar([FromBody] GaragemModel garagemModel)
        {
            GaragemModel garagem = await _garagemRepositorio.Adicionar(garagemModel);
            return Ok(garagem);
        }

        [HttpPut("{codigo}")]
        public async Task<ActionResult<GaragemModel>> Atualizar([FromBody] GaragemModel garagemModel, string codigo)
        {
            garagemModel.Codigo = codigo;
            GaragemModel garagem = await _garagemRepositorio.Atualizar(garagemModel, codigo);
            return Ok(garagem);
        }

        [HttpDelete("{codigo}")]
        public async Task<ActionResult<GaragemModel>> Apagar(string codigo)
        {
            bool apagado = await _garagemRepositorio.Apagar(codigo);
            return Ok(apagado);
        }
    }
}
