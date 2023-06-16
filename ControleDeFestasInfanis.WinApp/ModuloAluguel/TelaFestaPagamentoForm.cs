using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaFestaPagamentoForm : Form
    {
        public Aluguel aluguel { get; set; }

        public TelaFestaPagamentoForm(Aluguel aluguel)
        {
            InitializeComponent();
            this.aluguel = aluguel;

            CarregarOpcoesDePgto();

            ObterPagamento(aluguel);
        }

        public Pagamento ObterPagamento(Aluguel aluguel)
        {
            decimal valorEntrada = aluguel.pagamento.valorEntrada;

            PgtoEfetuadoEnum pgtoEfetuado = aluguel.pagamento.pgtoEfetuado;

            decimal valorTotal = aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.valorDesconto / 10);

            decimal valorFinal = valorTotal - valorEntrada;

            TelaPrincipalForm.Tela.AtualizarRodape("O valor de entrada deve ser entre 40% e 50% do valor total!");

            return new(aluguel.pagamento.valorDesconto, valorEntrada, valorFinal, pgtoEfetuado);
        }

        internal void ConfigurarTela(Aluguel aluguel)
        {
            txtCliente.Text = aluguel.cliente.nome;
            decimal valorTotal = (aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.valorDesconto / 10));
            txtValorTotal.Text = valorTotal.ToString();
            txtValorEntrada.Text = (aluguel.pagamento.valorEntrada).ToString();
        }

        private void CarregarOpcoesDePgto()
        {
            OpcoesPgtoEnum[] pagamentos = Enum.GetValues<OpcoesPgtoEnum>();

            foreach (OpcoesPgtoEnum opcapPgto in pagamentos)
            {
                cmbPagamento.Items.Add(opcapPgto);
            }
            cmbPagamento.SelectedIndex = 0;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            decimal valorTotal = aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.valorDesconto / 10);

            aluguel.pagamento.valorEntrada = Convert.ToDecimal(txtValorEntrada.Text);
            aluguel.formaPagamento = (OpcoesPgtoEnum)cmbPagamento.SelectedItem;

            if (aluguel.pagamento.valorEntrada < valorTotal * 40 / 100 || aluguel.pagamento.valorEntrada > valorTotal * 50 / 100)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"O valor de entrada mínimo é de R$ {valorTotal * 40 / 100} e o valor máximo é de R$ {valorTotal * 50 / 100}!");

                DialogResult = DialogResult.None;

                return;
            }
            if (aluguel.formaPagamento == OpcoesPgtoEnum.Nenhum)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"Você deve selecionar sua forma de pagamento!");

                DialogResult = DialogResult.None;

                return;
            }
        }

        private void txtValorEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                string s = Regex.Replace(txt.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                txt.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                txt.Select(txt.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
