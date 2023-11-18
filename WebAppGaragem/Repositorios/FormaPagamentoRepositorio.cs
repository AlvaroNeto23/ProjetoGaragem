using Microsoft.EntityFrameworkCore;
using WebAppGaragem.Data;
using WebAppGaragem.Models;
using WebAppGaragem.Repositorios.Interfaces;

namespace WebAppGaragem.Repositorios
{
    public class FormaPagamentoRepositorio : IFormaPagamentoRepositorio
    {
        private readonly GaragemDbContext _dbContext;
        public FormaPagamentoRepositorio(GaragemDbContext garagemDbContext)
        {
            _dbContext = garagemDbContext;
        }

        public async Task<FormaPagamentoModel> BuscarPorCodigo(string codigo)
        {
            return await _dbContext.FormasPagamento.FirstOrDefaultAsync(x => x.Codigo == codigo);
        }

        public async Task<List<FormaPagamentoModel>> BuscarTodasFormasPagamento()
        {
            return await _dbContext.FormasPagamento.ToListAsync();
        }

        public async Task<FormaPagamentoModel> Adicionar(FormaPagamentoModel formaPagamento)
        {
            await _dbContext.FormasPagamento.AddAsync(formaPagamento);
            await _dbContext.SaveChangesAsync();

            return formaPagamento;
        }

        public async Task<FormaPagamentoModel> Atualizar(FormaPagamentoModel formaPagamento, string codigo)
        {
            FormaPagamentoModel model = await BuscarPorCodigo(codigo);

            if (model == null)
            {
                throw new Exception($"A Forma de Pagamento, código: {codigo}, não foi encontrada na base de dados.");
            }

            model.Descricao = formaPagamento.Descricao;

            _dbContext.FormasPagamento.Update(model);
            _dbContext.SaveChanges();

            return model;
        }

        public async Task<bool> Apagar(string codigo)
        {
            FormaPagamentoModel model = await BuscarPorCodigo(codigo);

            if (model == null)
            {
                throw new Exception($"A Forma de Pagamento, código: {codigo}, não foi encontrada na base de dados.");
            }

            _dbContext.FormasPagamento.Remove(model);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
