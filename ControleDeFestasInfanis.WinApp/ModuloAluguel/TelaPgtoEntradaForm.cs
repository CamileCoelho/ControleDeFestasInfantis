using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaPgtoEntradaForm : Form
    {
        public Aluguel aluguelSelecionado { get; set; }

        Desconto desconto { get; set; }

        public TelaPgtoEntradaForm(Desconto desconto)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarOpcoesDePgto();

            TelaPrincipalForm.Tela.AtualizarRodape("O valor de entrada deve ser entre 40% e 50% do valor total!");

            this.desconto = desconto;
        }

        public void ConfigurarTela(Aluguel aluguel)
        {
            decimal porcentagemDescontoTotal = aluguel.cliente.qtdAlugueisRealizados * desconto.porcentagemDesconto;

            if (aluguel.cliente.qtdAlugueisRealizados * desconto.porcentagemDesconto >= desconto.porcentagemDescontoMaximo)
            {
                porcentagemDescontoTotal = desconto.porcentagemDescontoMaximo;
            }

            txtCliente.Text = aluguel.cliente.nome;
            txtValorTotal.Text = (String.Format("{0:0.00}", (aluguel.festa.tema.valorTotalTema - (aluguel.festa.tema.valorTotalTema * porcentagemDescontoTotal / 100))));
            txtValorEntrada.Text = (String.Format("{0:0.00}", aluguel.pagamento.valorEntrada));
            aluguel.formaPagamento = OpcoesPgtoEnum.Nenhum;

            aluguelSelecionado = aluguel;
        }

        public Pagamento RealizarPagamentoDaEntrada()
        {
            decimal porcentagemDescontoTotal = aluguelSelecionado.cliente.qtdAlugueisRealizados * desconto.porcentagemDesconto;

            if (aluguelSelecionado.cliente.qtdAlugueisRealizados * desconto.porcentagemDesconto >= desconto.porcentagemDescontoMaximo)
            {
                porcentagemDescontoTotal = desconto.porcentagemDescontoMaximo;
            }

            decimal valorEntrada = Convert.ToDecimal(String.Format("{0:0.00}", txtValorEntrada.Text));
            decimal valorFinal = Convert.ToDecimal(String.Format("{0:0.00}", (aluguelSelecionado.pagamento.valorTotal - aluguelSelecionado.pagamento.valorEntrada)));
            decimal valorTotal = Convert.ToDecimal(String.Format("{0:0.00}", aluguelSelecionado.festa.tema.valorTotalTema - ((aluguelSelecionado.festa.tema.valorTotalTema * porcentagemDescontoTotal) / 100)));

            return new(valorEntrada, valorFinal, valorTotal);
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
            decimal porcentagemDescontoTotal = aluguelSelecionado.cliente.qtdAlugueisRealizados * desconto.porcentagemDesconto;

            if (aluguelSelecionado.cliente.qtdAlugueisRealizados * desconto.porcentagemDesconto >= desconto.porcentagemDescontoMaximo)
            {
                porcentagemDescontoTotal = desconto.porcentagemDescontoMaximo;
            }

            aluguelSelecionado.pagamento.valorEntrada = Convert.ToDecimal(String.Format("{0:0.00}", txtValorEntrada.Text));
            aluguelSelecionado.pagamento.valorTotal = Convert.ToDecimal(String.Format("{0:0.00}", aluguelSelecionado.festa.tema.valorTotalTema - ((aluguelSelecionado.festa.tema.valorTotalTema * porcentagemDescontoTotal) / 100)));
            aluguelSelecionado.pagamento.valorFinal = Convert.ToDecimal(String.Format("{0:0.00}", (aluguelSelecionado.pagamento.valorTotal - aluguelSelecionado.pagamento.valorEntrada)));
            aluguelSelecionado.formaPagamento = (OpcoesPgtoEnum)cmbPagamento.SelectedItem;
            aluguelSelecionado.pagamento.pgtoEfetuado = PgtoEfetuadoEnum.Parcial;

            if (aluguelSelecionado.pagamento.valorEntrada < aluguelSelecionado.pagamento.valorTotal * 40 / 100 || aluguelSelecionado.pagamento.valorEntrada > aluguelSelecionado.pagamento.valorTotal * 50 / 100)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"O valor de entrada mínimo é de R$ {aluguelSelecionado.pagamento.valorTotal * 40 / 100}" +
                    $" e o valor máximo é de R$ {aluguelSelecionado.pagamento.valorTotal * 50 / 100}!");

                DialogResult = DialogResult.None;

                return;
            }
            if (aluguelSelecionado.formaPagamento == OpcoesPgtoEnum.Nenhum)
            {
                TelaPrincipalForm.Tela.AtualizarRodape($"Você deve selecionar sua forma de pagamento!");

                DialogResult = DialogResult.None;
            }
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
