namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Pagamento
    {
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
