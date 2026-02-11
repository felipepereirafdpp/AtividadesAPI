namespace AtividadesAPI.Barbearia
{
    public class DadosMocados
    {
        public static IList<BarbeirosModel> RetornarBarbeiros() //Criando um método estático que retorna uma lista de barbeiros
        {
            List<BarbeirosModel> lista = new List<BarbeirosModel>(); // Criando uma lista para armazenar os barbeiros
            BarbeirosModel barbeiro1 = new BarbeirosModel(1, "Luizinho", " ", "Especialista em cortes clássicos e barba bem feita."); //Escrevendo um barbeiro com id, nome, imagem (vazia) e descrição
            BarbeirosModel barbeiro2 = new BarbeirosModel(2, "Livia", " ", "Conhecida por suas habilidades em cortes modernos e design de barba criativo.");//Escrevendo outro barbeiro com id, nome, imagem (vazia) e descrição
            BarbeirosModel barbeiro3 = new BarbeirosModel(3, "Otavio", " ", "Famoso por sua precisão em cortes de cabelo e barba, além de um atendimento amigável."); //Escrvendo o mais um barbeiro com id, nome, imagem (vazia) e descrição
            lista.Add(barbeiro1);//Adicionando o primeiro barbeiro à lista
            lista.Add(barbeiro2); //Adicionando o segundo barbeiro à lista
            lista.Add(barbeiro3); //Adicionando o terceiro barbeiro à lista
            return lista; //Retornando a lista de barbeiros
        }
        public static IList<AgendaBarbeirosModel> RetornarAgenda()
        {
            List<AgendaBarbeirosModel> listaHorario = new List<AgendaBarbeirosModel>();
            AgendaBarbeirosModel agenda1 = new AgendaBarbeirosModel(1, new List<string> { "09:00", "10:00", "11:00" });
            AgendaBarbeirosModel agenda2 = new AgendaBarbeirosModel(2, new List<string> { "09:00", "10:00", "11:00","11:30" });
            AgendaBarbeirosModel agenda3 = new AgendaBarbeirosModel(3, new List<string> { "09:00", "10:00", "11:00","11:30" });
            listaHorario.Add(agenda1);
            listaHorario.Add(agenda2);
            listaHorario.Add(agenda3);
            return listaHorario;
        }
        public static IList<AgendarCorteModel> RetornarAgendamento()
        {
            List<AgendarCorteModel> AgendarCorte = new List<AgendarCorteModel>();
            AgendarCorteModel agendamento1 = new AgendarCorteModel ("Felipe", 1, 1, "09:00");
            AgendarCorteModel agendamento2 = new AgendarCorteModel ("Breno", 2, 2 , "10:00");
            AgendarCorteModel agendamento3 = new AgendarCorteModel("Belasco", 3, 3, "10:00");
            AgendarCorte.Add(agendamento1);
            AgendarCorte.Add(agendamento2);
            AgendarCorte.Add(agendamento3);
            return AgendarCorte;
        }

        public static IList<ServicosModel> RetornarHorarios()
        {
            List<ServicosModel> listaServicos = new List<ServicosModel>();
            ServicosModel servico1 = new ServicosModel(1,"Corte Social",45,"30:00 Minutos");
            ServicosModel servico2 = new ServicosModel(2, "Corte Degrade",50,"50:00 Minutos");
            ServicosModel servico3 = new ServicosModel(3, "Corte + Barba",80,"1:00 Hora");
            listaServicos.Add(servico1);
            listaServicos.Add(servico2);
            listaServicos.Add(servico3);
            return listaServicos;
        }
    }
}
