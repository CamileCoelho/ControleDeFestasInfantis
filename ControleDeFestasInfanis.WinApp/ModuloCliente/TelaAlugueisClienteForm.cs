using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaAlugueisClienteForm : Form
    {
        public TelaAlugueisClienteForm(TabelaAlugueisClienteControl tabelaAlugueisCliente, Cliente clienteSelecionado)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.Text = $"Histórico de alugueis de {clienteSelecionado}:";

            tabelaAlugueisCliente.Dock = DockStyle.Fill;

            panelAlugueisCliente.Controls.Clear();

            panelAlugueisCliente.Controls.Add(tabelaAlugueisCliente);
        }
    }
}
