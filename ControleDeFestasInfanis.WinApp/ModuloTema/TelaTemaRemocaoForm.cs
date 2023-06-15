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

            ConfigurarTela(tema);
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.titulo;

            gridtensTema.ConfigurarGridZebrado();
            gridtensTema.ConfigurarGridSomenteLeitura();
            gridtensTema.Columns.AddRange(ObterColunas());

            foreach (var item in temaSelecionado.itens)
            {
                gridtensTema.Rows.Add(item.descricao, item.quantidade, (item.valor * item.quantidade));
            }

            tabelaItensTema.AtualizarRegistrosItens(temaSelecionado);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            foreach (var item in tema.itens)
            {
                tema.itens.Remove(item);
            }

            tabelaItensTema.AtualizarRegistrosItens(tema);
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
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
