using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        IRepositorioTema repositorioTema;
        IRepositorioItem repositorioItem;
        TabelaItemControl tabelaItens;

        public ControladorItem(IRepositorioTema repositorioTema, IRepositorioItem repositorioItem)
        {
            this.repositorioTema = repositorioTema;
            this.repositorioItem = repositorioItem;
        }

        public override string ToolTipInserir => "Inserir novo item";
        public override string ToolTipEditar => "Editar item existente";
        public override string ToolTipExcluir => "Exluir item existente";
        public override string ToolTipHome => "Home";
        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool HomeHabilitado => true;

        public override void Inserir()
        {           
            TelaItemForm telaItem = new(repositorioItem.SelecionarTodos());

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item item = telaItem.ObterItem();

                repositorioItem.Inserir(item);

                CarregarItens();
            }
        }

        public override void Editar()
        {
            Item itemSelecionado = ObterItemSelecionado();

            if (itemSelecionado == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Edição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaItemForm tela = new(repositorioItem.SelecionarTodos());

            tela.ConfigurarTela(itemSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item item = tela.ObterItem();

                repositorioItem.Editar(itemSelecionado, item);

                CarregarItens();
            }
        }

        public override void Excluir()
        {
            Item item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (repositorioTema.SelecionarTodos().Any(x => x.itens.Any(i => i.id == item.id)))
            {
                MessageBox.Show($"Não é possivel remover esse item pois ele possuí vinculo com ao menos um Tema!",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o item {item.descricao}?",
                "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioItem.Excluir(item);

                CarregarItens();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItens == null)
                tabelaItens = new TabelaItemControl();

            CarregarItens();

            return tabelaItens;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Itens";
        }

        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            tabelaItens.AtualizarRegistros(itens);
        }

        private Item ObterItemSelecionado()
        {
            int id = tabelaItens.ObterNumeroItemSelecionado();

            return repositorioItem.SelecionarPorId(id);
        }

        public override void Home()
        {
            TelaPrincipalForm tela = new TelaPrincipalForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

        }
    }
}
