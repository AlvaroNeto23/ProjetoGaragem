using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppGaragem.Models;

namespace WebAppGaragem.Data.Map
{
    public class PassagemMap : IEntityTypeConfiguration<PassagemModel>
    {
        public void Configure(EntityTypeBuilder<PassagemModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CarroPlaca).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CarroModelo).HasMaxLength(100);
            builder.Property(x => x.CarroMarca).HasMaxLength(100);
            builder.Property(x => x.DataHoraEntrada);
            builder.Property(x => x.DataHoraSaida);
            builder.Property(x => x.PrecoTotal);

            builder.Property(x => x.FormaPagamentoCodigo);
            builder.HasOne(x => x.FormaPagamento);

            builder.Property(x => x.GaragemCodigo);
            builder.HasOne(x => x.Garagem);
        }
    }
}
