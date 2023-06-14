
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaAdicaoForm : Form
    {
        private List<Item> listaItens;

        public List<Item> ListaItens
        {
            get { return listaItens; }
        }

        private Tema tema { get; set; }

        public TelaTemaAdicaoForm(Tema tema, List<Item> itens)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ObterItens(itens);

            ConfigurarTela(tema);
        }

        public void ObterItens(List<Item> itens)
        {
            this.listaItens = itens;
            foreach (Item item in itens)
            {
                cmbItensTema.Items.Add(item);
            }
        }

        public Tema ObterItensTema()
        {
            string nome = txtTema.Text;
            Item item = (Item)cmbItensTema.SelectedItem;
            string quantidade = numQtdDisponivel.Text;

            Tema tema = new Tema(nome);

            return tema;


            listItensTema.Items.Add(item);

        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.titulo;

            cmbItensTema.SelectedItem = temaSelecionado.itens;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtTema.Text;

            string quantidade = numQtdDisponivel.Text;

            Item item = (Item)cmbItensTema.SelectedItem;

         //   listItensTema.Items.Add(" item: " + item + " quantidade: " + quantidade);
            listItensTema.Items.Add(item);
            listItensTema.Items.Add(quantidade);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tema = ObterItensTema();

            string status = tema.Validar();

            if (status != "")
                DialogResult = DialogResult.None;

        }
    }
}
