namespace AtividadesAPI.FolhaPagamento
{
    public class ComissionadoModel : FuncionarioModel
    {
        public ComissionadoModel(string nome,string urlFoto,decimal percentualComissao, decimal totalVendas)
        {
           Nome = nome;
           UrlFoto = urlFoto;
           PercentualComissao = percentualComissao;
           TotalVendas = totalVendas;
        }

        public decimal PercentualComissao { get; set; }
        public decimal TotalVendas { get; set; }
        
        public override string Tipo => "Comissionado";

        public override decimal CalcularPagamento()
        {
            return TotalVendas * (PercentualComissao / 100);
        }
    }
}
