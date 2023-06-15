using ControleDeFestasInfantis.Dominio.ModuloItem;

namespace ControleDeFestasInfantis.WinApp.ModuloItem
{
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Descrição", HeaderText = "Descrição"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"}
            };

            return colunas;
        }

        public int ObterNumeroItemSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Item> itens)
        {
            grid.Rows.Clear();

            foreach (var item in itens)
            {
                grid.Rows.Add(item.id, item.descricao,
                    "R$ " + item.valor);
            }
        }
    }
}
