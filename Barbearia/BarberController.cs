using Microsoft.AspNetCore.Mvc;

namespace AtividadesAPI.Barbearia
{
    [ApiController]
    [Route("[controller]")]

    public class BarbeariaController : ControllerBase
    {
        [HttpGet("Servico")]
        public IList<ServicosModel> ListarServicos()
        {
            return DadosMocados.RetornarHorarios();
        }

        [HttpGet("Barbeiros")]
        public IList<BarbeirosModel> ListarBarbeiros()
        {
            return DadosMocados.RetornarBarbeiros();
        }


        [HttpGet("Agenda")]
        public IList<AgendaBarbeirosModel> ListarAgenda()
        {
            return DadosMocados.RetornarAgenda();
        }
        

        [HttpGet("CortesMarcados")]
        public IList<AgendarCorteModel> AgendarCorte() 
        { 
            return DadosMocados.RetornarAgendamento();
        }

    }
}
