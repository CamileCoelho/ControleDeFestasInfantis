using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.Dominio.ModuloItem
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string descricao { get; set; }
        public int quantidadeDisponivel { get; set; }
        public int quantidadeLocada { get; set; }
        public decimal valor { get; set; }

        public Item()
        {
            
        }

        public Item(string descricao, string quantidadeDisponivel, string quantidadeLocada, string valor)
        {
            this.descricao = descricao;
            this.quantidadeDisponivel = Int32.Parse(quantidadeDisponivel);
            this.quantidadeLocada = Int32.Parse(quantidadeLocada);
            this.valor = Decimal.Parse(valor); 
        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.quantidadeDisponivel = registroAtualizado.quantidadeDisponivel;
            this.valor = registroAtualizado.valor;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(descricao))
                return $"Você deve escrever uma descrição!";
            if (descricao.Length <= 5)
                return $"A descrição deve conter no mínimo 6 caracteres!";
            if (valor == 0)
                return $"O valor deve ser maior que zero!";

            return "";
        }

        public override string ToString()
        {
            return descricao;
        }
    }
}
