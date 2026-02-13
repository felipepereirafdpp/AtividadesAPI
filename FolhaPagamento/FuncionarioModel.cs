namespace AtividadesAPI.FolhaPagamento
{
    public abstract class FuncionarioModel
    {
        public  string Nome { get; set; }
        public  string UrlFoto { get; set; }

        public decimal Pagamento => CalcularPagamento();

        public abstract string Tipo { get;}

        public abstract decimal CalcularPagamento();

    }
}
