﻿
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaAdicaoForm : Form
    {
        private Tema tema { get; set; }

        private TabelaItensTema tabelaItensTema;

        public TelaTemaAdicaoForm(Tema tema, List<Item> itens)
        {
            InitializeComponent();

            this.tema = tema;
            this.ConfigurarDialog();

            ObterItens(itens);

            if (tabelaItensTema == null)
                tabelaItensTema = new TabelaItensTema();

            ConfigurarTela(tema);
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

            gridtensTema.ConfigurarGridZebrado();
            gridtensTema.ConfigurarGridSomenteLeitura();
            gridtensTema.Columns.AddRange(ObterColunas());

            foreach (var item in temaSelecionado.itens)
            {
                gridtensTema.Rows.Add(item.descricao, item.quantidade, (item.valor * item.quantidade));
            }

            tabelaItensTema.AtualizarRegistrosItens(temaSelecionado);
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Item item = (Item)cmbItensTema.SelectedItem;
            item.quantidade = numQuantidadeItem.Value;

            gridtensTema.Rows.Add(item.descricao, item.quantidade, (item.valor * item.quantidade));
            tema.itens.Add(item);   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

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
    }
}
