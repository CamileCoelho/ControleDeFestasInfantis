using ControleDeFestasInfantis.Dominio.ModuloFesta;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using System.Drawing;

namespace ControleDeFestasInfantis.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {
        public string titulo { get; set; }
        public DisponivelParaLocacaoEnum statusTema { get; set; }
        public List<Item> itens { get; set; }

        public Tema()
        {

        }

        public Tema(string titulo)
        {
            this.titulo = titulo;
            itens = new List<Item>();
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            titulo = registroAtualizado.titulo;
            statusTema = registroAtualizado.statusTema;
        }

        public void InserirItem(Item item)
        {
            if (itens.Contains(item))
                return;

            itens.Add(item);
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
