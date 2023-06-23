namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    public class Desconto
    {
        public decimal porcentagemDesconto { get; set; } // calcula de acordo com a quantidade de alugueis realizados, com o desconto máximo de 15%
        public decimal porcentagemDescontoMaximo { get; set; }

        public Desconto()
        {
            porcentagemDesconto = 1;
            porcentagemDescontoMaximo = 15;
        }

        public Desconto(decimal porcentagemDesconto, decimal porcentagemDescontoMaximo)
        {
            this.porcentagemDesconto = porcentagemDesconto;
            this.porcentagemDescontoMaximo = porcentagemDescontoMaximo;
        }

        public string Validar()
        {
            Validador valida = new();

            if (porcentagemDesconto > porcentagemDescontoMaximo)
                return "A porcentagem de desconto não pode ultrapassar a porcentagem máxima!";

            return "";
        }
    }
}
