using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaFinalizarPagamentoForm : Form
    {
        Aluguel aluguel { get; set; }

        public TelaFinalizarPagamentoForm(Aluguel aluguel)
        {
            InitializeComponent();
            this.aluguel = aluguel;

            CarregarOpcoesDePgto();
        }

        internal void ConfigurarTela(Aluguel aluguel)
        {
            txtCliente.Text = aluguel.cliente.nome;
            decimal valorTotal = (aluguel.festa.tema.valorTotalTema - Convert.ToDecimal(aluguel.pagamento.valorDesconto / 10));
            txtValorTotal.Text = valorTotal.ToString();
            txtValorFinal.Text = (aluguel.pagamento.valorFinal).ToString();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
