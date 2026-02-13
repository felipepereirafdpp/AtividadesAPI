namespace AtividadesAPI.GeometriaAbstract
{
    public abstract class FormaModel
    {
        public decimal Area => CalcularArea();
        public decimal Perimetro => CalcularPerimetro();
        public abstract string Tipo { get; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
