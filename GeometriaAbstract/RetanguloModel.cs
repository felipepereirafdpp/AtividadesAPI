namespace AtividadesAPI.GeometriaAbstract
{
    public class RetanguloModel : FormaModel
    {
        public RetanguloModel(decimal largura, decimal altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override string Tipo => "Retangulo";

        public decimal Largura { get; set; }
        public decimal Altura { get; set; }
        public override decimal CalcularArea()
        {
            return Largura * Altura;
        }
        public override decimal CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
