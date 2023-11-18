using System.ComponentModel.DataAnnotations;

namespace WebAppGaragem.Models
{
    public class FormaPagamentoModel
    {
        [Key]
        public string Codigo { get; set; }
        public string? Descricao { get; set; }
    }
}
