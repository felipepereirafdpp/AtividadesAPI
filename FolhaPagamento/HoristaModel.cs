namespace AtividadesAPI.FolhaPagamento
{
    public class HoristaModel: FuncionarioModel
    {
        public HoristaModel(string nome, string urlFoto, decimal horasTrabalhadas, decimal valorPorHora)
        {
            Nome = nome;
            UrlFoto = urlFoto;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        public decimal HorasTrabalhadas {  get; set; }
        public decimal ValorPorHora { get; set;}
        public override string Tipo => "Horista";
        public override decimal CalcularPagamento()
        {
            return (HorasTrabalhadas * ValorPorHora);
        }
    }
}
