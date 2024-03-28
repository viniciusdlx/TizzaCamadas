using Repositorio;
using TizzaAula;

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

        public void Inserir(InserirPizzariaDTO inserirPizzariaDTO)
        {
            var pizzaria = new Pizzaria();
            pizzaria.Nome = inserirPizzariaDTO.Nome;
            pizzaria.Telefone = inserirPizzariaDTO.Telefone;
            pizzaria.Endereco = inserirPizzariaDTO.Endereco;

            _repoPizzaria.Inserir(pizzaria);
        }
    }
}
