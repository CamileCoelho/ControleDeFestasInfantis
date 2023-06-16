namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Pagamento
    {
        public double valorDesconto { get; set; } // calcula de acordo com a quantidade de alugueis realizados, cada aluguel aumenta 2,5% o deconto sendo o desconto máximo de 15%, ou seja, 6 alugueis  
        public double valorEntrada { get; set; } // deve ser entre 40%  e 50% do valor total
        public decimal valorFinal { get; set; } 
        public PgtoEfetuadoEnum pgtoEfetuado { get; set; }

        public Pagamento()
        {
            
        }

        public Pagamento(double valorDesconto, double valorEntrada, PgtoEfetuadoEnum pgtoEfetuado)
        {
            this.valorDesconto = valorDesconto;
            this.valorEntrada = valorEntrada;
            this.pgtoEfetuado = pgtoEfetuado;
        }
    }
}
