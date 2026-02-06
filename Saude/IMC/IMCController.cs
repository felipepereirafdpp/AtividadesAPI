using Microsoft.AspNetCore.Mvc;

namespace AtividadesAPI.Saude.IMC
{
    [ApiController]
    [Route("[controller]")]
    public class IMCController : ControllerBase
    {
        [HttpGet]
        public  CalcularIMCModel Get(decimal altura, decimal peso)
        {
            return new CalcularIMCModel(altura , peso);
        }
    }
}
