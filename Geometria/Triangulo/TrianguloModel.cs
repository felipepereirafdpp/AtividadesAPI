namespace AtividadesAPI.Geometria.Triangulo
{
    public class TrianguloModel
    {
        public TrianguloModel(decimal basee, decimal altura)
        {
            Basee = basee;
            Altura = altura;
            Area = (basee * altura) / 2;
           
        }

        public decimal Basee { get; }
        public decimal Altura { get; }

        public decimal Area { get; }

        
    }
}