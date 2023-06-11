using ControleDeFestasInfantis.Dominio.ModuloItem;
using System.Text.RegularExpressions;

namespace ControleDeFestasInfantis.WinApp.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private Item item { get; set; }

        public TelaItemForm(bool edicaoDoItem)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            if (edicaoDoItem)
            {
                numQtdLocada.Enabled = false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            item = ObterItem();

            string status = item.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }

        public Item ObterItem()
        {
            string descricao = txtDescricao.Text;

            string quantidadeDisponivel = numQtdDisponivel.Text;

            string qualtidadeLocada = numQtdLocada.Text;

            string valor = txtValor.Text;

            return new(descricao, quantidadeDisponivel, qualtidadeLocada, valor);
        }

        public void ConfigurarTela(Item itemSelecionado)
        {
            txtId.Text = itemSelecionado.id.ToString();
            txtDescricao.Text = itemSelecionado.descricao;
            numQtdDisponivel.Text = itemSelecionado.quantidadeDisponivel.ToString();
            numQtdLocada.Text = itemSelecionado.quantidadeLocada.ToString();
            txtValor.Text = itemSelecionado.valor.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string s = Regex.Replace(t.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                t.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
