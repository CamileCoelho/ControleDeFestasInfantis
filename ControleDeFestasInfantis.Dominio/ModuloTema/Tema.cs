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
        public decimal valorTotalTema { get; set; }

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

        public void InserirItens(List<Item> itensToAdd)
        {
            decimal valor;

            foreach (var item in itensToAdd)
            {
                valor = item.valor * item.quantidade;

                if (itens.Contains(item))
                    return;

                itens.Add(item);

                AtualizarValorTotalTema(valor);
            }
        }

        public void AtualizarValorTotalTema(decimal valor)
        {
            valorTotalTema += valor;
        }

        public void RemoverItens(List<Item> itensToRemove)
        {
            decimal valor;

            foreach (var item in itensToRemove)
            {
                itens.Remove(item);

                valor = -(item.valor * item.quantidade);

                AtualizarValorTotalTema(valor);
            }

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
