
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaAdicaoForm : Form
    {
        private Tema tema { get; set; }
        public List<Item> itensToAdd { get; set; }

        private TabelaItensTema tabelaItensTema;

        public TelaTemaAdicaoForm(Tema tema, List<Item> itens)
        {
            InitializeComponent();

            this.tema = tema;
            this.ConfigurarDialog();

            ObterItens(itens);

            if (tabelaItensTema == null)
                tabelaItensTema = new TabelaItensTema();

            itensToAdd = new List<Item>();
        }

        public void ObterItens(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                cmbItensTema.Items.Add(item);
            }
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.titulo;

            tabelaItensTema.Dock = DockStyle.Fill;

            panelItensTema.Controls.Clear();

            panelItensTema.Controls.Add(tabelaItensTema);

            tabelaItensTema.AtualizarRegistrosItens(temaSelecionado.itens);
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Item item = (Item)cmbItensTema.SelectedItem;
            item.quantidade = numQuantidadeItem.Value;

            itensToAdd.Add(item);

            tabelaItensTema.AtualizarRegistrosItens(item);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
