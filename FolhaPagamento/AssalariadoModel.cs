using System.Globalization;

namespace AtividadesAPI.FolhaPagamento
{
    public class AssalariadoModel: FuncionarioModel
    {
        public AssalariadoModel(string nome, string urlFoto, decimal salario, decimal desconto)
        {
            Nome = nome;
            UrlFoto = urlFoto;
            Salario = salario;
            Desconto = desconto;
        }

        public decimal Salario { get; set;}
        public decimal Desconto { get; set;}
        public override string Tipo => "Assalariado";

        public override decimal CalcularPagamento()
        {
            return (Salario - Desconto);
        }

    }
}
