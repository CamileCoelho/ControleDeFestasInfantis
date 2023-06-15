using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Infra.Json.ModuloTema
{
    public class RepositorioTemaArquivo : RepositorioBaseArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Tema> ObterRegistros()
        {
            return contextoDeDados.temas;
        }
    }
}
