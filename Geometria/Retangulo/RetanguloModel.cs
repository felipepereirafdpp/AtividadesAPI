using System.Security.Cryptography.X509Certificates;

namespace AtividadesAPI.Geometria.Retangulo
{
    public class RetanguloModel
    {
        public RetanguloModel(decimal largura, decimal altura)
        {
            Largura = largura;
            
            Altura = altura;

            Area = largura * altura;
            
            Perimetro = (largura * 2) + (altura * 2);
        }

        public decimal Largura { get; }
        public decimal Altura { get; }
        public decimal Area { get;}
        public decimal Perimetro { get; }

        
    }
}
