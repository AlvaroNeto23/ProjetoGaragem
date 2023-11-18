using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppGaragem.Models;
using WebAppGaragem.Repositorios;
using WebAppGaragem.Repositorios.Interfaces;

namespace WebAppGaragem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaPagamentoController : ControllerBase
    {
        private readonly IFormaPagamentoRepositorio _formaPagamentoRepositorio;
        public FormaPagamentoController(IFormaPagamentoRepositorio formaPagamentoRepositorio)
        {
            _formaPagamentoRepositorio = formaPagamentoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<FormaPagamentoModel>>> BuscarTodasFormasPagamento()
        {
            List<FormaPagamentoModel> formasPagamento = await _formaPagamentoRepositorio.BuscarTodasFormasPagamento();
            return Ok(formasPagamento);
        }

        [HttpGet("{codigo}")]
        public async Task<ActionResult<FormaPagamentoModel>> BuscarPorCodigo(string codigo)
        {
            FormaPagamentoModel formaPagamento = await _formaPagamentoRepositorio.BuscarPorCodigo(codigo);
            return Ok(formaPagamento);
        }

        [HttpPost]
        public async Task<ActionResult<FormaPagamentoModel>> Cadastrar([FromBody] FormaPagamentoModel formaPagamentoModel)
        {
            FormaPagamentoModel formaPagamento = await _formaPagamentoRepositorio.Adicionar(formaPagamentoModel);
            return Ok(formaPagamento);
        }

        [HttpPut("{codigo}")]
        public async Task<ActionResult<FormaPagamentoModel>> Atualizar([FromBody] FormaPagamentoModel formaPagamentoModel, string codigo)
        {
            formaPagamentoModel.Codigo = codigo;
            FormaPagamentoModel formaPagamento = await _formaPagamentoRepositorio.Atualizar(formaPagamentoModel, codigo);
            return Ok(formaPagamento);
        }

        [HttpDelete("{codigo}")]
        public async Task<ActionResult<FormaPagamentoModel>> Apagar(string codigo)
        {
            bool apagado = await _formaPagamentoRepositorio.Apagar(codigo);
            return Ok(apagado);
        }
    }
}
