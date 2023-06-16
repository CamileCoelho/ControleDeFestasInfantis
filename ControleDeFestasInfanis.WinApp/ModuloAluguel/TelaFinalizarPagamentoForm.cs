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
            decimal valorTotal = aluguel.festa.tema.valorTotalTema - (aluguel.pagamento.valorDesconto / 10);
            txtValorTotal.Text = valorTotal.ToString();
            txtValorFinal.Text = aluguel.pagamento.valorFinal.ToString();
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
