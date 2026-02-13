namespace AtividadesAPI.GeometriaAbstract
{
    public class DadosMocados
    {
        public static List<FormaModel> RetornarDados()
        {
           
                List<FormaModel> models = new ();
                RetanguloModel forma1 = new (10, 10);
                CirculoModel forma2 = new (5);
                models.Add(forma1);
                models.Add(forma2);
                return models;
            
        }
    }
}
