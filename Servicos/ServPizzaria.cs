using Entidades;
using Repositorio;

namespace Servicos
{
    public interface IServPizzaria
    {
        void Inserir(InserirPizzariaDTO inserirPizzariaDto);
    }

    public class ServPizzaria : IServPizzaria
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
