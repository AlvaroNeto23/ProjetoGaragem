using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppGaragem.Models;

namespace WebAppGaragem.Data.Map
{
    public class FormaPagamentoMap : IEntityTypeConfiguration<FormaPagamentoModel>
    {
        public void Configure(EntityTypeBuilder<FormaPagamentoModel> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}
