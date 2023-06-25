using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaConfiguracaoDescontoForm : Form
    {
        Desconto desconto { get; set; }

        public TelaConfiguracaoDescontoForm(Desconto desconto)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.desconto = desconto;

            ConfigurarTela();
        }

        public void ConfigurarTela()
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

        private void numPorcentagemDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                NumericUpDown num = (NumericUpDown)sender;
                string s = Regex.Replace(num.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                num.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                num.Select(num.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void numDescontoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                NumericUpDown num = (NumericUpDown)sender;
                string s = Regex.Replace(num.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                num.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                num.Select(num.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
