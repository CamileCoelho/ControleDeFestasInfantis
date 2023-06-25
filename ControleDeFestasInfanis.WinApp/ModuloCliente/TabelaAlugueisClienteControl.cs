using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaAlugueisClienteControl : UserControl
    {
        public TabelaAlugueisClienteControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Pagamento", HeaderText = "Pagamento"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data de quitação", HeaderText = "Data de quitação"}
            
            };

            return colunas;
        }

        public void AtualizarRegistros(List<Aluguel> alugueisCliente)
        {
            grid.Rows.Clear();

            foreach (var aluguel in alugueisCliente)
            {
                grid.Rows.Add(aluguel.id, DateOnly.FromDateTime(aluguel.festa.data),
                aluguel.cliente.nome, aluguel.cliente.telefone, aluguel.festa.tema,
                "R$ " + (aluguel.pagamento.valorTotal).ToString("###,###.00"), 
                aluguel.pagamento.pgtoEfetuado, aluguel.status, 
                aluguel?.dataQuitacao.Date.ToString("dd/MM/yyyy"));
            }
        }
    }
}

