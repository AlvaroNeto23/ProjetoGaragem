using Microsoft.EntityFrameworkCore;
using WebAppGaragem.Data.Map;
using WebAppGaragem.Models;

namespace WebAppGaragem.Data
{
    public class GaragemDbContext : DbContext
    {
        public GaragemDbContext(DbContextOptions<GaragemDbContext> options) : base(options)
        {                
        }

        public DbSet<FormaPagamentoModel> FormasPagamento { get; set; }
        public DbSet<GaragemModel> Garagens { get; set; }
        public DbSet<PassagemModel> Passagens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FormaPagamentoMap());
            modelBuilder.ApplyConfiguration(new GaragemMap());
            modelBuilder.ApplyConfiguration(new PassagemMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
