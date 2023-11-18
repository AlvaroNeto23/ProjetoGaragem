using WebAppGaragem.Models;

namespace WebAppGaragem.Repositorios.Interfaces
{
    public interface IGaragemRepositorio
    {
        Task<List<GaragemModel>> BuscarTodasGaragens();
        Task<GaragemModel> BuscarPorCodigo(string codigo);
        Task<GaragemModel> Adicionar(GaragemModel garagem);
        Task<GaragemModel> Atualizar(GaragemModel garagem, string codigo);
        Task<bool> Apagar(string codigo);
    }
}
