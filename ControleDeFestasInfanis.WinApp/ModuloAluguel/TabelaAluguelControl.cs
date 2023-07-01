using ControleDeFestasInfantis.Dominio.ModuloAluguel;

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

            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Pagamento", HeaderText = "Pagamento"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data de quitação", HeaderText = "Data de quitação"}
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
                    aluguel.cliente.nome, aluguel.cliente.telefone, aluguel.festa.tema,
                    "R$ " + (aluguel.pagamento.valorTotal).ToString("###,###.00"), 
                    aluguel.pagamento.pgtoEfetuado, aluguel.status, 
                    aluguel.dataQuitacao.HasValue ? aluguel.dataQuitacao.Value.ToString("dd/MM/yyyy") : "");
            }
        }
    }
}