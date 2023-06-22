using ControleDeFestasInfantis.Dominio.ModuloCliente;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente { get; set; }
        private Cliente clienteSelecionado { get; set; }
        private List<Cliente> clientes { get; set; }


        public TelaClienteForm(List<Cliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            
            this.clientes = clientes;
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString().Trim();
            txtNome.Text = clienteSelecionado.nome;
            txtTelefone.Text = clienteSelecionado.telefone.ToString();
            txtEmail.Text = clienteSelecionado.email;

            this.clienteSelecionado = clienteSelecionado;
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            return new(id, nome, telefone, email, new());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string status = "";
            
            cliente = ObterCliente();
            
            if (clientes.Where(i => cliente.id != clienteSelecionado?.id).Any(x => x.nome == cliente.nome))
                status = $"Já existe um cliente cadastrado com esse nome!";
            else
                status = cliente.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}