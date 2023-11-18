using System.ComponentModel.DataAnnotations;

namespace WebAppGaragem.Models
{
    public class GaragemModel
    {
        [Key]
        public string Codigo { get; set; }
        public string? Nome { get; set; }
        public decimal Preco_1aHora { get; set; }
        public decimal Preco_HorasExtra { get; set; }
        public decimal Preco_Mensalista { get; set; }
    }
}
