namespace AtividadesAPI.FolhaPagamento
{
    public class DadosMocados
    {
        public static IList<FuncionarioModel> RetornarDados()
        {
            List<FuncionarioModel> model = new List<FuncionarioModel>();
            HoristaModel funcionario1 = new HoristaModel("Felipe", "https://randomuser.me/api/portraits/men/65.jpg", 8,50);            
            AssalariadoModel funcionario2 = new AssalariadoModel("Pedro", "https://randomuser.me/api/portraits/men/60.jpg", 5000, 500);            
            ComissionadoModel funcionario3 = new ComissionadoModel("Felipe", "https://randomuser.me/api/portraits/men/33.jpg", 10, 10000);

            model.Add(funcionario1);
            model.Add(funcionario2);
            model.Add(funcionario3);
            return model;
        }
    }
}
