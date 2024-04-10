using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicos;

namespace Apresentacao
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PromoverController : ControllerBase
    {
        private IServPromover _servPromover;

        public PromoverController(IServPromover servPromover)
        {
            _servPromover = servPromover;
        }

        [HttpPost]
        public ActionResult Inserir(InserirPromoverDTO inserirDto)
        {
            try
            {
                _servPromover.Inserir(inserirDto);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[Controller]/Efetivar/{id}")]
        [HttpPost]
        public ActionResult Efetivar(int id)
        {
            try
            {
                _servPromover.Efetivar(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            try
            {
                /*var pizzarias = _servPizzaria.BuscarTodos();

                var pizzariaEnxuta = pizzarias.Select(p =>
                    new
                    {
                        Id = p.Id,
                        Nome = p.Nome
                    }).ToList();*/

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/{id}")]
        [HttpDelete]
        public IActionResult Remover(int id)
        {
            try
            {
                //_servPizzaria.Remover(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
