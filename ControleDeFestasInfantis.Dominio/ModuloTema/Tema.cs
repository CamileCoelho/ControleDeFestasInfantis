using ControleDeFestasInfantis.Dominio.ModuloFesta;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using System.Drawing;
using System.Windows.Forms;

namespace ControleDeFestasInfantis.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {
        public string titulo { get; set; }
        public DisponivelParaLocacaoEnum statusTema { get; set; }
        public List<Item> itens { get; set; }
        public decimal valorTotal { get; set; }

        public Tema()
        {
            
        }

        public Tema(string titulo)
        {
            this.titulo = titulo;
            itens = new List<Item>();
        }

        public Tema(List<Item> itens) 
        {
            foreach (Item item in itens)
            {
                valorTotal = item.valor * item.quantidade;
            }
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            titulo = registroAtualizado.titulo;
            statusTema = registroAtualizado.statusTema;

            if(registroAtualizado.itens != null)
            {
                this.itens = registroAtualizado.itens;
            }
            foreach (Item item in itens)
            {
                registroAtualizado.valorTotal = item.valor * item.quantidade;
            }
        }

        public void InserirItens(Tema tema)
        {
            foreach (var item in tema.itens)
            {
                if (tema.itens.Contains(item))
                    return;

                tema.itens.Add(item);
            }            
        }

        public void RemoverItem(Item item)
        {
            if (itens.Contains(item))
                itens.Remove(item);
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(titulo))
                return $"Você deve escrever um titulo!";
            if (titulo.Length <= 4)
                return $"O titulo deve conter no mínimo 5 caracteres!";

            return "";
        }
    }
}
