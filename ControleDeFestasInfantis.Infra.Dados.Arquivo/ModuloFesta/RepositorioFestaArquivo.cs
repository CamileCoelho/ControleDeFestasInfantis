using ControleDeFestasInfantis.Dominio.ModuloFesta;

namespace ControleDeFestasInfantis.Infra.Dados.Arquivo.ModuloFesta
{
    public class RepositorioFestaArquivo : RepositorioBaseArquivo<Festa>, IRepositorioCliente
    {
        public RepositorioFestaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDeDados.contatos;
        }
    }
}
