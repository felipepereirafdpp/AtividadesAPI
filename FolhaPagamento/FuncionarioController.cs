using Microsoft.AspNetCore.Mvc;

namespace AtividadesAPI.FolhaPagamento
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet("Funcionarios")]
        public IList<FuncionarioModel> GerarDados()
        {
            return DadosMocados.RetornarDados();
        }
    }
}
