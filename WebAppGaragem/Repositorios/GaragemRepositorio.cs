using Microsoft.EntityFrameworkCore;
using WebAppGaragem.Data;
using WebAppGaragem.Models;
using WebAppGaragem.Repositorios.Interfaces;

namespace WebAppGaragem.Repositorios
{
    public class GaragemRepositorio : IGaragemRepositorio
    {
        private readonly GaragemDbContext _dbContext;
        public GaragemRepositorio(GaragemDbContext garagemDbContext)
        {
            _dbContext = garagemDbContext;
        }

        public async Task<GaragemModel> BuscarPorCodigo(string codigo)
        {
            return await _dbContext.Garagens.FirstOrDefaultAsync(x => x.Codigo == codigo);
        }

        public async Task<List<GaragemModel>> BuscarTodasGaragens()
        {
            return await _dbContext.Garagens.ToListAsync();
        }

        public async Task<GaragemModel> Adicionar(GaragemModel garagem)
        {
            await _dbContext.Garagens.AddAsync(garagem);
            await _dbContext.SaveChangesAsync();

            return garagem;
        }

        public async Task<GaragemModel> Atualizar(GaragemModel garagem, string codigo)
        {
            GaragemModel model = await BuscarPorCodigo(codigo);

            if (model == null)
            {
                throw new Exception($"A Garagem, código: {codigo}, não foi encontrada na base de dados.");
            }

            model.Nome = garagem.Nome;
            model.Preco_Mensalista = garagem.Preco_Mensalista;
            model.Preco_1aHora = garagem.Preco_1aHora;
            model.Preco_HorasExtra = garagem.Preco_HorasExtra;

            _dbContext.Garagens.Update(model);
            await _dbContext.SaveChangesAsync();

            return model;
        }

        public async Task<bool> Apagar(string codigo)
        {
            GaragemModel model = await BuscarPorCodigo(codigo);

            if (model == null)
            {
                throw new Exception($"A Garagem, código: {codigo}, não foi encontrada na base de dados.");
            }

            _dbContext.Garagens.Remove(model);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
