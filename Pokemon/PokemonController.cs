using Microsoft.AspNetCore.Mvc;

namespace AtividadesAPI.Pokemon
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public IList<PokemonModel> ApresentarOpcoes()
        {
             return DadosMocados.RetornarPokemon() ;
        }
    }
}
