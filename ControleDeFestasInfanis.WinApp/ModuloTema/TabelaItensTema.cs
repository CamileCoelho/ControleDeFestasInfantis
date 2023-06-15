using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaItensTema : UserControl
    {
        public TabelaItensTema()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

            };

            return colunas;
        }

        public int ObterNumeroTemaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistrosItens(Tema tema)
        {
            grid.Rows.Clear();

            foreach (var item in tema.itens)
            {
                grid.Rows.Add(item.descricao, item.quantidade, (item.valor * item.quantidade));
            }
        }
    }
}