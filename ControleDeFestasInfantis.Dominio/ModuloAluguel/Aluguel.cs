using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public StatusAluguelEnum status { get; set; } // se pagamento.PgtoEfetuadoEnum = PgtoEfetuadoEnum.Completo status=finalizado
        public OpcoesPgtoEnum formaPagamento { get; set; }
        public Pagamento pagamento { get; set; }
        public Cliente cliente { get; set; }
        public Festa festa { get; set; }

        public Aluguel()
        {
            
        }

        public Aluguel(Cliente cliente, Festa festa)
        {
            this.cliente = cliente;
            this.festa = festa;

            if (cliente != null)
            {
                pagamento = new();
                pagamento.valorDesconto = cliente.qtdAlugueisRealizados * 2.5;
                pagamento.pgtoEfetuado = PgtoEfetuadoEnum.Pendente;
            }
            
            status = StatusAluguelEnum.Em_andamento;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            cliente = registroAtualizado.cliente;
            festa = registroAtualizado.festa;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (cliente == null)
                return $"Você deve selecionar um cliente!";

            if (valida.ValidaString(festa.endereco.cidade))
                return $"Você deve escrever a cidade onde será sua festa!";

            if (valida.ValidaString(festa.endereco.rua))
                return $"Você deve escrever a rua onde será sua festa!";

            if (festa.endereco.numero <= 0)
                return $"O seu numero deve ser positivo e maior que zero!";

            if (valida.ValidaDateTime(festa.data))
                return $"Você deve adicionar a data de sua festa!";

            if (valida.ValidaDateTimeComTimeOnly(festa.horarioInicio))
                return $"Você deve adicionar o horario de início!";

            if (valida.ValidaDateTimeComTimeOnly(festa.horarioTermino))
                return $"Você deve adicionar o horario de término!";

            if (festa.horarioTermino <= festa.horarioInicio)
                return $"O horario de término deve ser posterior ao horário de início!";

            if (festa.tema == null)
                return $"Você deve selecionar um tema!";

            return "";
        }
    }
}
