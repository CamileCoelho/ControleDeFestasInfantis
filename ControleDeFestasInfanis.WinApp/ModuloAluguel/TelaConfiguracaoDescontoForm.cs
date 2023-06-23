using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaConfiguracaoDescontoForm : Form
    {
        Desconto desconto { get; set; }

        public TelaConfiguracaoDescontoForm(Desconto desconto)
        {
            InitializeComponent();

            this.desconto = desconto;

            ConfigurarTela(desconto);
        }

        public void ConfigurarTela(Desconto desconto)
        {
            numPorcentagemDesconto.Value = desconto.porcentagemDesconto;
            numDescontoMaximo.Value = desconto.porcentagemDescontoMaximo;
        }

        public Desconto ObterDesconto()
        {
            decimal porcentagemDesconto = numPorcentagemDesconto.Value;
            decimal descontoMaximo = numDescontoMaximo.Value;

            return new(porcentagemDesconto, descontoMaximo);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Desconto desconto = ObterDesconto();

            string status = desconto.Validar();

            if (status != "")
            {
                TelaPrincipalForm.Tela.AtualizarRodape(status);

                DialogResult = DialogResult.None;
            }
            else
                TelaPrincipalForm.Tela.AtualizarRodape("Configurações de desconto salvas com sucesso!");
        }
    }
}
