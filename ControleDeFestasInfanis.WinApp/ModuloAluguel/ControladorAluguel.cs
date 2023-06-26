using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using ControleDeFestasInfantis.WinApp.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioDesconto repositorioDesconto;
        private TabelaAluguelControl tabelaAlugueis;

        public ControladorAluguel(IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema, IRepositorioAluguel repositorioAluguel, IRepositorioDesconto repositorioDesconto)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioDesconto = repositorioDesconto;
        }

        public override string ToolTipInserir => "Realizar novo aluguelSelecionado";
        public override string ToolTipEditar => "Editar aluguelSelecionado existente";
        public override string ToolTipExcluir => "Excluir aluguelSelecionado existente";
        public override string ToolTipFiltrar => "Filtrar alugueis";
        public override string ToolTipFinalizarPagamento => "Finalizar pagamento de um aluguelSelecionado existente";
        public override string ToolTipConfigDesconto => "Configurar percentuais de desconto";
        public override string ToolTipHome => "Home";

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool HomeHabilitado => true;
        public override bool FiltrarHabilitado => true;
        public override bool FiltrarVisivel => true;
        public override bool SeparadorVisivel1 => true;
        public override bool SeparadorVisivel4 => true;
        public override bool FinalizarPagamentoHabilitado => true;
        public override bool FinalizarPagamentoVisivel => true;
        public override bool ConfigDescontoHabilitado => true;
        public override bool ConfigDescontoVisivel => true;

        public override void Inserir()
        {
            if (repositorioCliente.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show($"Você deve cadastrar ao menos um cliente para poder realizar um aluguel!",
                    "Inserção de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (repositorioTema.SelecionarTodos().Any(x => x.itens.Count() == 0))
            {
                MessageBox.Show($"Você deve cadastrar ao menos um tema com itens dentro para poder realizar um aluguel!",
                    "Inserção de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm tela = new(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = tela.ObterAluguel();

                Desconto desconto = repositorioDesconto.ObterDesconto();

                TelaPgtoEntradaForm telaPgto = new(desconto);

                telaPgto.ConfigurarTela(aluguel);
                telaPgto.ShowDialog();

                if (telaPgto.DialogResult == DialogResult.Cancel)
                {
                    tela.DialogResult = DialogResult.Cancel;

                    TelaPrincipalForm.Tela.AtualizarRodape("");

                    return;
                }

                aluguel.pagamento = telaPgto.RealizarPagamentoDaEntrada();
                aluguel.pagamento.pgtoEfetuado = PgtoEfetuadoEnum.Parcial;
                aluguel.cliente.alugueisCliente.Add(aluguel);

                TelaPrincipalForm.Tela.AtualizarRodape("");

                repositorioAluguel.Inserir(aluguel);
            }

            CarregarAlugueis();
        }

        public override void Editar()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (aluguelSelecionado.status == StatusAluguelEnum.Finalizado)
            {
                MessageBox.Show($"Esse aluguel já foi finalizado, você não pode editá-lo!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm tela = new(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());

            tela.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = tela.ObterAluguel();

                aluguel.pagamento = aluguelSelecionado.pagamento;

                repositorioAluguel.Editar(aluguelSelecionado, aluguel);

                TelaPrincipalForm.Tela.AtualizarRodape("");
            }

            CarregarAlugueis();
        }

        public override void Filtrar()
        {
            TelaFiltroAluguelForm telaFiltroAluguel = new TelaFiltroAluguelForm();

            DialogResult opcaoEscolhida = telaFiltroAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Aluguel> alugueis;

                StatusAluguelEnum status = telaFiltroAluguel.ObterFiltroAluguel();

                switch (status)
                {
                    case StatusAluguelEnum.Em_andamento:
                        alugueis = repositorioAluguel.SelecionarPendentes();
                        break;

                    case StatusAluguelEnum.Finalizado:
                        alugueis = repositorioAluguel.SelecionarConcluidas();
                        break;

                    default:
                        alugueis = repositorioAluguel.SelecionarTodos();
                        break;
                }

                CarregarAlugueis();
            }
        }

        public override void Excluir()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Exclusão de alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (aluguelSelecionado.status == StatusAluguelEnum.Em_andamento)
            {
                MessageBox.Show($"Esse aluguel ainda não foi finalizado, você não pode excluí-lo!",
                    "Exclusão de alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida =
                MessageBox.Show($"Deseja excluir o aluguel {aluguelSelecionado.id}?",
                "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Excluir(aluguelSelecionado);
            }

            CarregarAlugueis();
        }

        public override void FinalizarPagamento()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Pagamento de alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (aluguelSelecionado.pagamento.pgtoEfetuado == PgtoEfetuadoEnum.Completo)
            {
                MessageBox.Show($"Esse aluguel já teve seu pagamento efetuado!",
                    "Pagamento de alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaPgtoFinalForm tela = new();

            tela.ConfigurarTela(aluguelSelecionado);
            tela.ShowDialog();

            if (tela.DialogResult == DialogResult.OK)
            {
                aluguelSelecionado.dataQuitacao = DateTime.Now;

                aluguelSelecionado.pagamento.pgtoEfetuado = PgtoEfetuadoEnum.Completo;

                aluguelSelecionado.status = StatusAluguelEnum.Finalizado;

                TelaPrincipalForm.Tela.AtualizarRodape("");
            }

            CarregarAlugueis();
        }

        public override void ConfigurarDesconto()
        {
            TelaConfiguracaoDescontoForm tela = new(repositorioDesconto.ObterDesconto());

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Desconto novoDesconto = tela.ObterDesconto();

                repositorioDesconto.GravarDescontoEmArquivoJson(novoDesconto);
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAlugueis == null)
                tabelaAlugueis = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAlugueis;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Alugueis";
        }

        public Aluguel ObterAluguelSelecionado()
        {
            int id = tabelaAlugueis.ObterNumeroAluguelSelecionado();

            return repositorioAluguel.SelecionarPorId(id);
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();
            tabelaAlugueis.AtualizarRegistros(alugueis);
        }

        public override void Home()
        {
            TelaPrincipalForm tela = new TelaPrincipalForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

        }
    }
}
