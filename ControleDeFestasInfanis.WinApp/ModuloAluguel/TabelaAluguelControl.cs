using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Pagamento", HeaderText = "Pagamento"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status"}
            };

            return colunas;
        }

        public int ObterNumeroAluguelSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (var aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, DateOnly.FromDateTime(aluguel.festa.data),
                    aluguel.cliente, aluguel.festa.tema, aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.valorDesconto / 10),
                    aluguel.pagamento.pgtoEfetuado, aluguel.status);
            }
        }
    }
}