using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente { get; set; }
        private List<Cliente> clientes { get; set; }


        public TelaClienteForm(List<Cliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.clientes = clientes;
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
            string status = "";
            
            cliente = ObterCliente();
            
            if (clientes.Any(x => x.nome == cliente.nome))
                status = $"Já existe um cliente cadastrado com esse nome!";
            else
                status = cliente.Validar();

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