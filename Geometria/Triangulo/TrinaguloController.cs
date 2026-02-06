using Microsoft.AspNetCore.Mvc;

namespace AtividadesAPI.Geometria.Triangulo
{
    [ApiController]
    [Route("[controller]")]
    public class TrinaguloController : ControllerBase
    {
        [HttpGet]
        public TrianguloModel Get(decimal basee , decimal altura)
        {
            return new TrianguloModel(basee,altura);
        }
    }
}
