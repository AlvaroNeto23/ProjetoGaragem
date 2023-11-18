namespace WebAppGaragem.Models
{
    public class PassagemModel
    {
        public int Id { get; set; }
        public string? CarroPlaca { get; set; }
        public string? CarroMarca { get; set; }
        public string? CarroModelo { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public decimal PrecoTotal { get; set; }

        public int? FormaPagamentoCodigo { get; set; }
        public virtual FormaPagamentoModel? FormaPagamento { get; set; }

        public int? GaragemCodigo { get; set; }
        public virtual GaragemModel? Garagem { get; set; }
    }
}
