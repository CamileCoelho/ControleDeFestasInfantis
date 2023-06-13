using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;


namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        IRepositorioItem repositorioItem;
        IRepositorioTema repositorioTema;
        TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioItem repositorioItem, IRepositorioTema repositorioTema)
        {
            this.repositorioItem = repositorioItem;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir novo tema";

        public override string ToolTipEditar => "Editar tema existente";

        public override string ToolTipExcluir => "Excluir tema existente ";

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool AdicionarItensHabilitado => true;

        public override void Inserir()
        {
            // List<Item> item = repositorioItem.SelecionarTodos();
            TelaTemaForm tela = new TelaTemaForm();

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

            // List<Item> itens = repositorioItem.SelecionarTodos();
            TelaTemaForm telaTema = new TelaTemaForm();

            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(tema.id, tema);
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
                MessageBox.Show($"Selecione uma tema primeiro!",
                    "Adição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Item> itens = CarregarItens();

            TelaTemaAdicaoForm telaAdicao = new TelaTemaAdicaoForm(temaEscolhido, itens);

            DialogResult opcaoEscolhida = telaAdicao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                foreach (Item item in telaAdicao.ObterItensTema())
                {
                    temaEscolhido.InserirItem(item);
                }

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
