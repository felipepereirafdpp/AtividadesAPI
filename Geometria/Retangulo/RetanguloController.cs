using Microsoft.AspNetCore.Mvc;
namespace AtividadesAPI.Geometria.Retangulo

{
    [ApiController]
    [Route("[controller]")]
    public class RetanguloController : ControllerBase
    {
        [HttpGet]
        public RetanguloModel Get(decimal largura , decimal altura )
        {

            return new RetanguloModel(largura,altura);

        }
    }
}
