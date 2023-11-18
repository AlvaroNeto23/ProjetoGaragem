using Microsoft.EntityFrameworkCore;
using WebAppGaragem.Data;
using WebAppGaragem.Models;
using WebAppGaragem.Repositorios.Interfaces;

namespace WebAppGaragem.Repositorios
{
    public class PassagemRepositorio : IPassagemRepositorio
    {
        private readonly GaragemDbContext _dbContext;
        public PassagemRepositorio(GaragemDbContext garagemDbContext)
        {
            _dbContext = garagemDbContext;
        }

        public async Task<PassagemModel> BuscarPorId(int id)
        {
            return await _dbContext.Passagens
                .Include(x => x.FormaPagamento)
                .Include(x => x.Garagem)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PassagemModel>> BuscarTodasPassagens()
        {
            return await _dbContext.Passagens
                .Include(x => x.FormaPagamento)
                .Include(x => x.Garagem)
                .ToListAsync();
        }

        public async Task<PassagemModel> Adicionar(PassagemModel passagem)
        {
            await _dbContext.Passagens.AddAsync(passagem);
            await _dbContext.SaveChangesAsync();

            return passagem;
        }

        public async Task<PassagemModel> Atualizar(PassagemModel passagem, int id)
        {
            PassagemModel model = await BuscarPorId(id);

            if (model == null)
            {
                throw new Exception($"A Passagem, id: {id}, não foi encontrada na base de dados.");
            }

            model.CarroMarca = passagem.CarroMarca;
            model.CarroPlaca = passagem.CarroPlaca;
            model.CarroModelo = passagem.CarroModelo;
            model.DataHoraEntrada = passagem.DataHoraEntrada;
            model.DataHoraSaida = passagem.DataHoraSaida;
            model.PrecoTotal = passagem.PrecoTotal;
            
            model.FormaPagamentoCodigo = passagem.FormaPagamentoCodigo;
            model.GaragemCodigo = passagem.GaragemCodigo;

            _dbContext.Passagens.Update(model);
            await _dbContext.SaveChangesAsync();

            return model;
        }

        public async Task<bool> Apagar(int id)
        {
            PassagemModel model = await BuscarPorId(id);

            if (model == null)
            {
                throw new Exception($"A Passagem, id: {id}, não foi encontrada na base de dados.");
            }

            _dbContext.Passagens.Remove(model);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
