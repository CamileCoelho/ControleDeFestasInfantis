using ControleDeFestasInfantis.Dominio.ModuloFesta;

namespace ControleDeFestasInfantis.Infra.Json.ModuloFesta
{
    public class RepositorioFestaArquivo : RepositorioBaseArquivo<Festa>, IRepositorioFesta
    {
        public RepositorioFestaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Festa> ObterRegistros()
        {
            return contextoDeDados.festas;
        }
    }
}
