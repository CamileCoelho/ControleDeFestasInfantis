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

            this.ConfigurarDialog();

            this.aluguel = aluguel;

            CarregarOpcoesDePgto();
        }

        public Pagamento ObterPagamento()
        {
            decimal valorTotal = aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.porcentagemDesconto / 10);

            decimal valorEntrada = Convert.ToDecimal(String.Format("{0:0.00}", txtValorEntrada.Text));
            
            decimal valorFinal = valorTotal - valorEntrada;

            TelaPrincipalForm.Tela.AtualizarRodape("O valor de entrada deve ser entre 40% e 50% do valor total!");

            return new(valorEntrada, valorFinal, valorTotal);
        }

        internal void ConfigurarTela(Aluguel aluguel)
        {
            txtCliente.Text = aluguel.cliente.nome;
            txtValorTotal.Text = aluguel.pagamento.valorTotal.ToString();
            txtValorEntrada.Text = (String.Format("{0:0.00}", aluguel.pagamento.valorEntrada).ToString());
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
            aluguel.pagamento.valorTotal = aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.porcentagemDesconto / 10);

            aluguel.pagamento = ObterPagamento();

            aluguel.formaPagamento = (OpcoesPgtoEnum)cmbPagamento.SelectedItem;

            if (aluguel.pagamento.valorEntrada < aluguel.pagamento.valorTotal * 40 / 100 || aluguel.pagamento.valorEntrada > aluguel.pagamento.valorTotal * 50 / 100)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"O valor de entrada mínimo é de R$ {aluguel.pagamento.valorTotal * 40 / 100} e o valor máximo é de R$ {aluguel.pagamento.valorTotal * 50 / 100}!");

                DialogResult = DialogResult.None;

                return;
            }
            if (aluguel.formaPagamento == OpcoesPgtoEnum.Nenhum)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"Você deve selecionar sua forma de pagamento!");

                DialogResult = DialogResult.None;
            }

            aluguel.pagamento.valorFinal = aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.porcentagemDesconto / 10) - (aluguel.pagamento.valorEntrada);
            aluguel.pagamento.pgtoEfetuado =  PgtoEfetuadoEnum.Parcial;
            aluguel.cliente.qtdAlugueisRealizados++;
        }

        private void txtValorEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox txt = (TextBox)sender;
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
