using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaAdicaoForm : Form
    {
        public TelaTemaAdicaoForm(Tema tema, List<Item> itens)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarItens(itens);

            ConfigurarTela(tema);
        }

        public List<Item> ObterItensTema()
        {
            return listItensTema.Items.Cast<Item>().ToList();
        }

        private void ConfigurarTela(Tema tema)
        {
            txtId.Text = tema.id.ToString();
            txtTema.Text = tema.titulo;
            listItensTema.Items.Add(tema.itens);

        }

        private void CarregarItens(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                cmbItensTema.Items.Add(item);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Item item = (Item)cmbItensTema.SelectedItem;
            listItensTema.Items.Add(item);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
