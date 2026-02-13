using Microsoft.AspNetCore.Mvc;

namespace AtividadesAPI.GeometriaAbstract
{
    [ApiController]
    [Route("[controller]")]
    public class FormaController : ControllerBase
    {
        [HttpGet("geometria")]
        public IList<FormaModel> GetCalculos()
        {
            return DadosMocados.RetornarDados();
        }
    }
}
