using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Infra.Json.ModuloTema
{
    public class RepositorioTemaArquivo : RepositorioBaseArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        public void InserirItem(Tema tema, Item item)
        {
            Tema temaSelecionado = base.SelecionarPorId(tema.id);
            temaSelecionado.itens.Add(item);
            base.contextoDeDados.GravarEmArquivoJson();
        }

        protected override List<Tema> ObterRegistros()
        {
            return contextoDeDados.temas;
        }
    }
}
