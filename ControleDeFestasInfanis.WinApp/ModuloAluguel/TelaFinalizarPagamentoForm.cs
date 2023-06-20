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

            this.ConfigurarDialog();

            CarregarOpcoesDePgto();

            ConfigurarTela(aluguel);
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

            foreach (OpcoesPgtoEnum opcapPgto in pagamentos)
            {
                cmbPagamento.Items.Add(opcapPgto);
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
