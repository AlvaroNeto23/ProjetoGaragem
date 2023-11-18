using WebAppGaragem.Models;

namespace WebAppGaragem.Repositorios.Interfaces
{
    public interface IFormaPagamentoRepositorio
    {
        Task<List<FormaPagamentoModel>> BuscarTodasFormasPagamento();
        Task<FormaPagamentoModel> BuscarPorCodigo(string codigo);
        Task<FormaPagamentoModel> Adicionar(FormaPagamentoModel formaPagamento);
        Task<FormaPagamentoModel> Atualizar(FormaPagamentoModel formaPagamento, string codigo);
        Task<bool> Apagar (string codigo);
    }
}
