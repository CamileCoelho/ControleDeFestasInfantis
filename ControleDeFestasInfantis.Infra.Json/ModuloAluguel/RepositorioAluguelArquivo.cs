using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.Infra.Json.ModuloFesta
{
    public class RepositorioAluguelArquivo : RepositorioBaseArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        public List<Aluguel> SelecionarConcluidas()
        {
            return ObterRegistros()
                .Where(x => x.status == StatusAluguelEnum.Finalizado).ToList();
        }

        public List<Aluguel> SelecionarPendentes()
        {
            return ObterRegistros()
                 .Where(x => x.status == StatusAluguelEnum.Em_andamento).ToList();
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDeDados.alugueis;
        }
    }
}
