using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.Dominio.ModuloItem
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public decimal quantidade { get; set; }

        public Item()
        {
            
        }

        public Item(int id, string descricao, string valor)
        {
            this.id = id;
            this.descricao = descricao;
            this.valor = Decimal.Parse(valor); 
        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.valor = registroAtualizado.valor;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(descricao))
                return $"Você deve escrever uma descrição!";
            if (descricao.Length <= 4)
                return $"A descrição do item deve conter no mínimo 5 caracteres!";
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
