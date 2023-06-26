using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using ControleDeFestasInfantis.Infra.Json.Compartilhado;

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
            // .Where(x => x.pagamento.pgtoEfetuado == PgtoEfetuadoEnum.Completo).ToList();
        }

        public List<Aluguel> SelecionarPendentes()
        {
            return ObterRegistros()
                 .Where(x => x.status == StatusAluguelEnum.Em_andamento).ToList();
            // .Where(x=>x.pagamento.pgtoEfetuado == PgtoEfetuadoEnum.Pendente).ToList();
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDeDados.alugueis;
        }
    }
}
