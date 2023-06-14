using ControleDeFestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente { get; set; }
        public TelaClienteForm()
        {
            InitializeComponent();
        }
        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString();
            txtNome.Text = clienteSelecionado.nome;
            txtTelefone.Text = clienteSelecionado.telefone.ToString();
            txtEmail.Text = clienteSelecionado.email;
          
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            cliente = ObterCliente();

            string status = cliente.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }

        public Cliente ObterCliente()
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

          
            return new(nome, telefone, email);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}