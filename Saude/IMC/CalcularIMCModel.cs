namespace AtividadesAPI.Saude.IMC
{
    public class CalcularIMCModel
    {
        public CalcularIMCModel(decimal altura, decimal peso)
        {
            Altura = altura;
            Peso = peso;
            IMC = peso / (altura * altura);
        }

        public decimal Altura { get; }
        public decimal Peso { get; }

        public decimal IMC { get; }
    }
}