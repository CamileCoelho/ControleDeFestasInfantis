using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Dominio.ModuloFesta
{
    [Serializable]
    public class Pagamento : EntidadeBase<Pagamento>
    {
        public Cliente cliente { get; set; }
        public Tema tema { get; set; }
        public Pagamento()
        {
            
        }

        public override void AtualizarInformacoes(Pagamento registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
