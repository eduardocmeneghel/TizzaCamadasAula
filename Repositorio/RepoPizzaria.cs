using Entidades;

namespace Repositorio
{
    public interface IRepoPizzaria
    {
        void Inserir(Pizzaria pizzaria);
        void Editar(Pizzaria pizzaria);
        List<Pizzaria> BuscarTodos();
        Pizzaria BuscarPorId(int id);

        void Remover(Pizzaria pizzaria);
    }

    public class RepoPizzaria : IRepoPizzaria
    {
        private DataContext _dataContext;

        public RepoPizzaria(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Pizzaria pizzaria)
        {
            _dataContext.Add(pizzaria);

            _dataContext.SaveChanges();
        }

        public void Editar(Pizzaria pizzaria)
        {
            _dataContext.SaveChanges();
        }

        public List<Pizzaria> BuscarTodos()
        {
            var pizzarias = _dataContext.Pizzaria.ToList();

            return pizzarias;
        }

        public Pizzaria BuscarPorId(int id)
        {
            var pizzaria = _dataContext.Pizzaria.Where(p => p.Id == id).FirstOrDefault();

            return pizzaria;
        }

        public void Remover(Pizzaria pizzaria)
        {
            _dataContext.Remove(pizzaria);

            _dataContext.SaveChanges();
        }
    }
}
