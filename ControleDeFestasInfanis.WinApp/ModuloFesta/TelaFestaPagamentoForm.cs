using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloFesta;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaFestaPagamentoForm : Form
    {
        private Pagamento pagamento { get; set; }
        private List<Cliente> listaClientes;
        private List<Tema> listaTemaClientes;

        public TelaFestaPagamentoForm()
        {
            InitializeComponent();
        }

        private void CarregarPagamentos()
        {
            OpcoesPgtoEnum[] pagamentos = Enum.GetValues<OpcoesPgtoEnum>();

            foreach (OpcoesPgtoEnum pagamento in pagamentos)
            {
                cmbPagamento.Items.Add(pagamento);
            }
            cmbPagamento.SelectedIndex = 0;
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            this.listaClientes = clientes;
            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(clientes);
            }

        }

        private void CarregarTemaCliente(List<Tema> temas)
        {
            this.listaTemaClientes = temas;
            foreach (Tema tema in temas)
            {
                cmbTema.Items.Add(tema);
            }

            //if (cmbCliente.SelectedIndex == 1)
            //{
            //    cmbTema.Items.Add(new { Id = 1, Nome = "Item 2" });
            //}
        }
        public Pagamento ObterPagamento()
        {
            Pagamento pagamento = (Pagamento)cmbPagamento.SelectedItem;

            return new();
        }


        //public Cliente ObterCliente()
        //{
        //    Cliente cliente = (Cliente)cmbCliente.SelectedItem;
        //    Tema tema = (Tema)cmbTema.SelectedItem;
        //    //string valorEntrada = txtValorEnt.Text;
        //    //string valorTotal = txtValorEnt.Text;

        //    //   txtValorEnt.Text = valorEntrada.ToString();
        //   return;
        //}

    }
}
