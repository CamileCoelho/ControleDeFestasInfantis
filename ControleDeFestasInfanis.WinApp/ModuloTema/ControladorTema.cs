using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        IRepositorioAluguel repositorioAluguel;
        IRepositorioItem repositorioItem;
        IRepositorioTema repositorioTema;
        TabelaTemaControl tabelaTema;
        TabelaItensTema tabelaItensTema;

        public ControladorTema(IRepositorioAluguel repositorioAluguel, IRepositorioItem repositorioItem, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioItem = repositorioItem;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir novo tema";

        public override string ToolTipEditar => "Editar tema existente";

        public override string ToolTipExcluir => "Excluir tema existente";

        public override string ToolTipAdicionarItens => "Adicionar itens em um tema existente";

        public override string ToolTipRemoverItens => "Remover itens de um tema existente";

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool SeparadorVisivel1 => true;
        public override bool AdicionarItensHabilitado => true;
        public override bool RemoverItensHabilitado => true;
        public override bool AdicionarItensVisivel => true;
        public override bool RemoverItensVisivel => true;


        public override void Inserir()
        {
            if (CarregarItens().Count() == 0)
            {
                MessageBox.Show($"Você deve cadastrar ao menos um item para poder criar um tema!",
                    "Inserção de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaForm tela = new(repositorioTema.SelecionarTodos());

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = tela.ObterTema();

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }
        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaForm telaTema = new(repositorioTema.SelecionarTodos());

            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(temaSelecionado, tema);
            }

            CarregarTemas();
        }

        public override void Excluir()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de temas",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioAluguel.SelecionarTodos().Any(x => x.festa.tema == temaSelecionado))
            {
                MessageBox.Show($"Não é possivel remover esse tema pois ele possuí vinculo com ao menos um Aluguel!",
                    "Exclusão de temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            DialogResult opcaoEscolhida =
                MessageBox.Show($"Deseja excluir o tema {temaSelecionado.titulo}?",
                "Exclusão de Temas",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(temaSelecionado);
            }

            CarregarTemas();
        }

        public override void AdicionarItens()
        {
            Tema temaEscolhido = ObterTemaSelecionado();

            if (temaEscolhido == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Adição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Item> itens = CarregarItens();

            TelaTemaAdicaoForm telaAdicao = new(temaEscolhido, itens);

            telaAdicao.ConfigurarTela(temaEscolhido);

            DialogResult opcaoEscolhida = telaAdicao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.AdcionarItens(telaAdicao.itensToAdd, temaEscolhido);

                CarregarTemas();
            }
        }

        public override void RemoverItens()
        {
            //TO-DO  VERIFICAR SE CONTEM ALUGEUL PARA ESSE TEMA, SE SIM NÃO PODE REMOVER ITENS

            Tema temaEscolhido = ObterTemaSelecionado();

            if (temaEscolhido == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Adição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (temaEscolhido.itens.Count() == 0)
            {
                MessageBox.Show($"Você deve cadastrar itens em um tema para poder remove-los!",
                    "Remoção de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaRemocaoForm telaRemocao = new(temaEscolhido, temaEscolhido.itens);

            telaRemocao.ConfigurarTela();

            DialogResult opcaoEscolhida = telaRemocao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.RemoverItens(telaRemocao.itensToRemove, temaEscolhido);

                CarregarTemas();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(temas);
        }

        public Tema ObterTemaSelecionado()
        {
            int id = tabelaTema.ObterNumeroTemaSelecionado();

            return repositorioTema.SelecionarPorId(id);
        }

        private List<Item> CarregarItens()
        {
            return repositorioItem.SelecionarTodos();
        }
    }
}