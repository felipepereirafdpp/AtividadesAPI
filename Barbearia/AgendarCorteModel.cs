using System.Collections.Specialized;
using System.Globalization;

namespace AtividadesAPI.Barbearia
{
    public class AgendarCorteModel
    {
        public AgendarCorteModel(string nomeCliente, int tipoCorte, int idBarbeiro, string horario)
        {
            NomeCliente = nomeCliente;
            TipoCorte = tipoCorte;
            IdBarbeiro = idBarbeiro;
            Horario = horario;
        }

        public string NomeCliente { get; }
        public int TipoCorte { get; }
        public int IdBarbeiro {get;}
        public string Horario { get; }
        
    }
}