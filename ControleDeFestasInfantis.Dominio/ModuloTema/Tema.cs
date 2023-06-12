using ControleDeFestasInfantis.Dominio.ModuloItem;
using System.Drawing;

namespace ControleDeFestasInfantis.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {
        public string nome { get; set; }
        public Item item;

        public Tema()
        {
            
        }

        public Tema(int id, string nome, Item item)
        {
            this.id = id;
            this.nome = nome;
            this.item = item;
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
          nome = registroAtualizado.nome;
          item = registroAtualizado.item;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(nome))
                return $"Você deve escrever um tema!";
            if (nome.Length <= 5)
                return $"O tema deve conter no mínimo 5 caracteres!";
            //if (valor == 0)
            //    return $"O valor deve ser maior que zero!";

            return "";
        }
    }
}
