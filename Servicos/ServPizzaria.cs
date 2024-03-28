using Entidades;
using Repositorio;

namespace Servicos
{
    public interface IServPizzaria
    {

    }

    public class ServPizzaria
    {
        private IRepoPizzaria _repoPizzaria;

        public ServPizzaria(IRepoPizzaria repoPizzaria)
        {
            _repoPizzaria = repoPizzaria;
        }

        public void Inserir(InserirPizzariaDTO inserirPizzariaDto)
        {
            var pizzaria = new Pizzaria();

            pizzaria.Nome = inserirPizzariaDto.Nome;
            pizzaria.Telefone = inserirPizzariaDto.Telefone;
            pizzaria.Endereco = inserirPizzariaDto.Endereco;

            _repoPizzaria.Inserir(pizzaria);
        }
    }
}
