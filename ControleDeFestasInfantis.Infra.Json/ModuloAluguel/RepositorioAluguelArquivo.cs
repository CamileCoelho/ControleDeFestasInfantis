using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloTema;

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
                    .Where(x => x.pagamento.pgtoEfetuado == PgtoEfetuadoEnum.Completo).ToList();
                   
        }

        public List<Aluguel> SelecionarPendentes()
        {
             return ObterRegistros()
                .Where(x=>x.pagamento.pgtoEfetuado == PgtoEfetuadoEnum.Pendente).ToList();
        }

        //public List<Aluguel> SelecionarTodos()
        //{
        //    return ObterRegistros();
                
        //}

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDeDados.alugueis;
        }
    }
}
