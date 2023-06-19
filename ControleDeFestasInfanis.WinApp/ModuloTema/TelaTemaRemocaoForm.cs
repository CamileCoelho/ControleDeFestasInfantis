using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaRemocaoForm : Form
    {
        private TabelaItensTema tabelaItensTema;
        private Tema tema { get; set; }
        public List<Item> itensToRemove { get; set; }

        public TelaTemaRemocaoForm(Tema tema, List<Item> itens)
        {
            InitializeComponent();

            this.tema = tema;

            this.ConfigurarDialog();

            if (tabelaItensTema == null)
                tabelaItensTema = new TabelaItensTema();

            tabelaItensTema.AtualizarRegistrosItens(tema.itens);

            itensToRemove = new List<Item>();
        }

        public void ConfigurarTela()
        {
            txtId.Text = tema.id.ToString();
            txtTema.Text = tema.titulo;

            tabelaItensTema.Dock = DockStyle.Fill;

            panelItensRemocao.Controls.Clear();

            panelItensRemocao.Controls.Add(tabelaItensTema);

            tabelaItensTema.AtualizarRegistrosItens(tema.itens);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = tabelaItensTema.ObterNumeroTemaSelecionado();
            Item item = tema.itens.FirstOrDefault(x => x.id == id);

            if (item == null)
                return;

            itensToRemove.Add(item);

            tabelaItensTema.AtualizarRegistrosItens(tema.itens.Except(itensToRemove).ToList());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
