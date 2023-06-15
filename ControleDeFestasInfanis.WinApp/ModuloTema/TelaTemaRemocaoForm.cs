using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaRemocaoForm : Form
    {
        private Tema tema { get; set; }

        private TabelaItensTema tabelaItensTema;

        public TelaTemaRemocaoForm(Tema tema)
        {
            InitializeComponent();

            this.tema = tema;
            this.ConfigurarDialog();

            if (tabelaItensTema == null)
                tabelaItensTema = new TabelaItensTema();
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.titulo;

            //gridtensTema.ConfigurarGridZebrado();
            //gridtensTema.ConfigurarGridSomenteLeitura();
            //gridtensTema.Columns.AddRange(ObterColunas());

            //foreach (var item in temaSelecionado.itens)
            //{
            //    gridtensTema.Rows.Add(item.id,item.descricao, item.quantidade, (item.valor * item.quantidade));
            //}

            tabelaItensTema.Dock = DockStyle.Fill;

            panelItensRemocao.Controls.Clear();

            panelItensRemocao.Controls.Add(tabelaItensTema);

            tabelaItensTema.AtualizarRegistrosItens(temaSelecionado);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = tabelaItensTema.ObterNumeroTemaSelecionado();
            Item item = tema.itens.FirstOrDefault(x => x.id == id);

            tema.itens.Remove(item);

            tabelaItensTema.AtualizarRegistrosItens(tema);
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Item", HeaderText = "Item"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

            };

            return colunas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
