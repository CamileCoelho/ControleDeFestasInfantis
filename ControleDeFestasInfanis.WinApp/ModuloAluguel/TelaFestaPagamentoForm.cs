using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaFestaPagamentoForm : Form
    {
        public Aluguel aluguelSelecionado { get; set; }

        public TelaFestaPagamentoForm(Aluguel aluguel)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarOpcoesDePgto();

            ConfigurarTela(aluguel);

            TelaPrincipalForm.Tela.AtualizarRodape("O valor de entrada deve ser entre 40% e 50% do valor total!");
        }

        public Pagamento ObterPagamento()
        {
            decimal valorTotal = aluguelSelecionado.festa.tema.valorTotalTema - (aluguelSelecionado.pagamento.porcentagemDesconto / 10);

            decimal valorEntrada = Convert.ToDecimal(String.Format("{0:0.00}", txtValorEntrada.Text));
            
            decimal valorFinal = valorTotal - valorEntrada;

            return new(valorEntrada, valorFinal, valorTotal);
        }

        public void RealizarPagamentoDaEntrada()
        {
            aluguelSelecionado.pagamento.valorFinal = aluguelSelecionado.festa.tema.valorTotalTema - (aluguelSelecionado.pagamento.porcentagemDesconto / 10) - (aluguelSelecionado.pagamento.valorEntrada);
            aluguelSelecionado.pagamento.pgtoEfetuado = PgtoEfetuadoEnum.Parcial;

            aluguelSelecionado.cliente.qtdAlugueisRealizados++;

            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        internal void ConfigurarTela(Aluguel aluguel)
        {
            txtCliente.Text = aluguel.cliente.nome;
            txtValorTotal.Text = (aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.porcentagemDesconto / 10)).ToString();
            txtValorEntrada.Text = (String.Format("{0:0.00}", aluguel.pagamento.valorEntrada).ToString());

            this.aluguelSelecionado = aluguel;
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
            aluguelSelecionado.pagamento = ObterPagamento();

            aluguelSelecionado.formaPagamento = (OpcoesPgtoEnum)cmbPagamento.SelectedItem;

            if (aluguelSelecionado.pagamento.valorEntrada < aluguelSelecionado.pagamento.valorTotal * 40 / 100 || aluguelSelecionado.pagamento.valorEntrada > aluguelSelecionado.pagamento.valorTotal * 50 / 100)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"O valor de entrada mínimo é de R$ {aluguelSelecionado.pagamento.valorTotal * 40 / 100} e o valor máximo é de R$ {aluguelSelecionado.pagamento.valorTotal * 50 / 100}!");

                DialogResult = DialogResult.None;

                return;
            }
            if (aluguelSelecionado.formaPagamento == OpcoesPgtoEnum.Nenhum)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"Você deve selecionar sua forma de pagamento!");

                DialogResult = DialogResult.None;
            }

            //aluguelSelecionado.pagamento.valorFinal = aluguelSelecionado.festa.tema.valorTotalTema - (aluguelSelecionado.pagamento.porcentagemDesconto / 10) - (aluguelSelecionado.pagamento.valorEntrada);
            aluguelSelecionado.pagamento.pgtoEfetuado =  PgtoEfetuadoEnum.Parcial;
            aluguelSelecionado.cliente.qtdAlugueisRealizados++;
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
