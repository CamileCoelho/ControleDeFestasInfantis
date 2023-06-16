using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Infra.Json.ModuloFesta
{
    public class RepositorioAluguelArquivo : RepositorioBaseArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDeDados.alugueis;
        }
    }
}
