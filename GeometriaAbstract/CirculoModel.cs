namespace AtividadesAPI.GeometriaAbstract
{
    public class CirculoModel : FormaModel
    {
        public CirculoModel(decimal raio)
        {
            Raio = raio;
        }

        public decimal Raio {  get; set; }

        public override string Tipo => "Circulo";
        public override decimal CalcularArea()
        {
            return (decimal)3.14 * (Raio * Raio);   
        }
        public override decimal CalcularPerimetro()
        {
            return ((decimal)3.14 * (decimal)3.14) * Raio;
        }
    }
}
