using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppGaragem.Models;

namespace WebAppGaragem.Data.Map
{
    public class GaragemMap : IEntityTypeConfiguration<GaragemModel>
    {
        public void Configure(EntityTypeBuilder<GaragemModel> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Preco_1aHora);
            builder.Property(x => x.Preco_HorasExtra);
            builder.Property(x => x.Preco_Mensalista);
        }
    }
}
