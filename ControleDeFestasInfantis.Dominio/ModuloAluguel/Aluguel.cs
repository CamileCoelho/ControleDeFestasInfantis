using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public OpcoesPgtoEnum formaPagameno { get; set; }
        public Endereco endereco { get; set; }
        public Cliente cliente { get; set; }
        public Festa festa { get; set; }
        public decimal valorDesconto { get; set; }
        public decimal valorEntrada { get; set; }

        public Aluguel()
        {
            
        }

        public Aluguel(Endereco endereco, Cliente cliente, Festa festa, decimal valorDesconto, decimal valorEntrada)
        {
            this.endereco = endereco;
            this.cliente = cliente;
            this.festa = festa;
            this.valorDesconto = valorDesconto;
            this.valorEntrada = valorEntrada;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
