using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using Microsoft.Win32;

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

        public void AdcionarItens(List<Item> itensToAdd, Tema tema)
        {
            tema.InserirItens(itensToAdd);

            contextoDeDados.GravarEmArquivoJson();
        }

        public void RemoverItens(List<Item> itensToRemove, Tema tema)
        {
            tema.RemoverItens(itensToRemove);

            contextoDeDados.GravarEmArquivoJson();
        }
    }
}
