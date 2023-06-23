
using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaPgtoFinalForm : Form
    {
        Aluguel aluguel { get; set; }

        public TelaPgtoFinalForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarOpcoesDePgto();
        }

        internal void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtCliente.Text = aluguelSelecionado.cliente.nome;
            txtValorTotal.Text = aluguelSelecionado.pagamento.valorTotal.ToString();
            txtValorFinal.Text = aluguelSelecionado.pagamento.valorFinal.ToString();

            this.aluguel = aluguelSelecionado;
        }

        private void CarregarOpcoesDePgto()
        {
            OpcoesPgtoEnum[] pagamentos = Enum.GetValues<OpcoesPgtoEnum>();

            foreach (OpcoesPgtoEnum opcaoPgto in pagamentos)
            {
                cmbPagamento.Items.Add(opcaoPgto);
            }
            cmbPagamento.SelectedIndex = 0;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            aluguel.formaPagamento = (OpcoesPgtoEnum)cmbPagamento.SelectedItem;

            if (aluguel.formaPagamento == OpcoesPgtoEnum.Nenhum)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"Você deve selecionar sua forma de pagamento!");

                DialogResult = DialogResult.None;

                return;
            }
        }
    }
}
