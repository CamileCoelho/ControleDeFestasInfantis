using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.Infra.Json.ModuloFesta
{
    public class RepositorioFestaArquivo : RepositorioBaseArquivo<Aluguel>, IRepositorioFesta
    {
        public RepositorioFestaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDeDados.festas;
        }
    }
}
