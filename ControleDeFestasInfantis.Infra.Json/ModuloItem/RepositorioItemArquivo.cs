using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloItem;

namespace ControleDeFestasInfantis.Infra.Json.ModuloItem
{
    public class RepositorioItemArquivo : RepositorioBaseArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Item> ObterRegistros()
        {
            return contextoDeDados.itens;
        }
    }
}
