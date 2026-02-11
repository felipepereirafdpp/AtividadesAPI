using System.Globalization;

namespace AtividadesAPI.Barbearia
{
    public class ServicosModel
    {
        public ServicosModel(int iD, string nomeServico, decimal valorServico, string duracaoServico)
        {
            ID = iD;
            NomeServico = nomeServico;
            ValorServico = valorServico;
            DuracaoServico = duracaoServico;
        }

        public int ID {get;}
        public string NomeServico {get;}
        public decimal ValorServico {get;}
        public string DuracaoServico {get;}
    }
}