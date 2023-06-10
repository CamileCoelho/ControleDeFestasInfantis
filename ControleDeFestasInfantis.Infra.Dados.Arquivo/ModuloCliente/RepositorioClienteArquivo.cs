using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.Infra.Dados.Arquivo.ModuloCliente
{
    public class RepositorioClienteArquivo : RepositorioBaseArquivo<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDeDados.contatos;
        }
    }
}
