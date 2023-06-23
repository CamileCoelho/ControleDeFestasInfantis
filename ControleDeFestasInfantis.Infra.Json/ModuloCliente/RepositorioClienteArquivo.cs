using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.Infra.Json.ModuloCliente
{
    public class RepositorioClienteArquivo : RepositorioBaseArquivo<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDeDados.clientes;
        }
    }
}
