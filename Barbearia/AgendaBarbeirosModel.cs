using System.Globalization;

namespace AtividadesAPI.Barbearia
{
    public class AgendaBarbeirosModel
    {
        public AgendaBarbeirosModel(int idBarbeiro, List<string> horariosDisponiveis)
        {
            IdBarbeiro = idBarbeiro;
            HorariosDisponiveis = horariosDisponiveis;
        }

        public int IdBarbeiro { get;}

        public List<string> HorariosDisponiveis { get; set; } = new();

    }
}