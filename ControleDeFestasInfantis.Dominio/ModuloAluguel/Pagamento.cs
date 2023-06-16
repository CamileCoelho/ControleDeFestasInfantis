namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Pagamento
    {
        public decimal valorDesconto { get; set; } // calcula de acordo com a quantidade de alugueis realizados, cada aluguel aumenta 2,5% o deconto sendo o desconto máximo de 15%, ou seja, 6 alugueis  
        public decimal valorEntrada { get; set; } 
        public decimal valorFinal { get; set; } 
        public PgtoEfetuadoEnum pgtoEfetuado { get; set; }

        public Pagamento()
        {
            
        }

        public Pagamento(decimal valorDesconto, decimal valorEntrada, decimal valorFinal, PgtoEfetuadoEnum pgtoEfetuado)
        {
            this.valorDesconto = valorDesconto;
            this.valorEntrada = valorEntrada;
            this.valorFinal = valorFinal;
            this.pgtoEfetuado = pgtoEfetuado;
        }
    }
}
