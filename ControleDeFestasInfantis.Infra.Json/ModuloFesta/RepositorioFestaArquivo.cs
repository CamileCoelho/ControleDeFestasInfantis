using ControleDeFestasInfantis.Dominio.ModuloFesta;

namespace ControleDeFestasInfantis.Infra.Json.ModuloFesta
{
    public class RepositorioFestaArquivo : RepositorioBaseArquivo<Pagamento>, IRepositorioFesta
    {
        public RepositorioFestaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Pagamento> ObterRegistros()
        {
            return contextoDeDados.festas;
        }
    }
}
