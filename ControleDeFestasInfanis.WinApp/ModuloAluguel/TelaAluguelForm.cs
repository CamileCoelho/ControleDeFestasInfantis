﻿using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        Aluguel aluguel { get; set; }

        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarClientes(clientes);

            CarregarTemas(temas);
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(txtId.Text);

            Pagamento pgto = new();

            Cliente cliente = (Cliente)cmbClientes.SelectedItem;

            Tema tema = (Tema)cmbTemas.SelectedItem;

            string cidade = txtCidade.Text;

            string rua = txtRua.Text;

            string textoNumero = txtNumero.Text;

            int numero;

            if (int.TryParse(textoNumero, out numero))
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }

            Endereco endereco = new(cidade, rua, numero);

            DateOnly data = DateOnly.FromDateTime(txtData.Value);
            TimeOnly horarioInicio = TimeOnly.FromDateTime(txtInicio.Value);
            TimeOnly horarioTermino = TimeOnly.FromDateTime(txtTermino.Value);

            Festa festa = new(tema, endereco, data, horarioInicio, horarioTermino);

            return new(id, pgto, cliente, festa);
        }

        internal void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("Você pode apenas editar a localização e a data de sua festa!");

            txtId.Text = aluguelSelecionado.id.ToString();
            cmbClientes.SelectedItem = aluguelSelecionado.cliente;
            cmbClientes.Enabled = false;
            cmbTemas.SelectedItem = aluguelSelecionado.festa.tema;
            cmbTemas.Enabled = false;
            txtCidade.Text = aluguelSelecionado.festa.endereco.cidade;
            txtRua.Text = aluguelSelecionado.festa.endereco.rua;
            txtNumero.Text = (aluguelSelecionado.festa.endereco.numero).ToString();
            txtData.Value = aluguelSelecionado.festa.data;
            txtInicio.Value = aluguelSelecionado.festa.horarioInicio;
            txtTermino.Value = aluguelSelecionado.festa.horarioTermino;
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cmbClientes.Items.Add(cliente);
            }
        }

        private void CarregarTemas(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                if(tema.itens.Count() > 0)
                    cmbTemas.Items.Add(tema);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            aluguel = ObterAluguel();

            string status = aluguel.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
            {
                DialogResult = DialogResult.None;
                return;
            }

            return;
        }

        private void txtNuemro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
