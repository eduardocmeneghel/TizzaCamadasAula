using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicos;

namespace Apresentacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzariaController : ControllerBase
    {
        public IServPizzaria _servPizzaria;

        public PizzariaController(IServPizzaria servPizzaria)
        {
            _servPizzaria = servPizzaria;
        }

        [HttpPost]
        public IActionResult Inserir(InserirPizzariaDTO pizzaria)
        {
            try
            {
                _servPizzaria.Inserir(pizzaria);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
