using WebAppGaragem.Models;

namespace WebAppGaragem.Repositorios.Interfaces
{
    public interface IPassagemRepositorio
    {
        Task<List<PassagemModel>> BuscarTodasPassagens();
        Task<PassagemModel> BuscarPorId(int id);
        Task<PassagemModel> Adicionar(PassagemModel passagem);
        Task<PassagemModel> Atualizar(PassagemModel passagem, int id);
        Task<bool> Apagar(int id);
    }
}
