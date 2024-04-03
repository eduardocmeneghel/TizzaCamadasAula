using Microsoft.AspNetCore.Mvc;
using Servicos;

namespace Apresentacao
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PizzariaController : ControllerBase
    {
        private IServPizzaria _servPizzaria;

        public PizzariaController(IServPizzaria servPizzaria)
        {
            _servPizzaria = servPizzaria;
        }

        [HttpPost]
        public ActionResult Inserir(InserirPizzariaDTO inserirDto)
        {
            try
            {
                _servPizzaria.Inserir(inserirDto);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
