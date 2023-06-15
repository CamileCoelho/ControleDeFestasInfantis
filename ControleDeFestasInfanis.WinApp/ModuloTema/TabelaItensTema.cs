using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaItensTema : UserControl
    {
        public TabelaItensTema()
        {
            InitializeComponent();

            gridtensTema.ConfigurarGridZebrado();
            gridtensTema.ConfigurarGridSomenteLeitura();
            gridtensTema.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Item", HeaderText = "Item"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

            };

            return colunas;
        }

        public int ObterNumeroTemaSelecionado()
        {
            return gridtensTema.SelecionarNumero<int>();
        }

        public void AtualizarRegistrosItens(Tema tema)
        {
            gridtensTema.Rows.Clear();

            foreach (var item in tema.itens)
            {
                gridtensTema.Rows.Add(item.id, item.descricao, item.quantidade, (item.valor * item.quantidade));
            }
        }
        public void AtualizarRegistrosItens(Item item)
        {
            gridtensTema.Rows.Add(item.id, item.descricao, item.quantidade, (item.valor * item.quantidade));
        }
    }
}