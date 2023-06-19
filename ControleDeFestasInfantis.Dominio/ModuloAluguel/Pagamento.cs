namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Pagamento
    {
        public decimal porcentagemDesconto { get; set; } // calcula de acordo com a quantidade de alugueis realizados, com o desconto máximo de 15%
        public decimal valorEntrada { get; set; } 
        public decimal valorFinal { get; set; }
        public decimal valorTotal { get; set; }
        public PgtoEfetuadoEnum pgtoEfetuado { get; set; }

        public Pagamento()
        {
            
        }

        public Pagamento(decimal valorEntrada, decimal valorFinal, decimal valorTotal)
        {
            this.valorEntrada = valorEntrada;
            this.valorFinal = valorFinal;
            this.valorTotal = valorTotal;
        }
    }
}
