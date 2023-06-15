using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using ControleDeFestasInfantis.WinApp.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public class ContoladorAluguel : ControladorBase
    {
        IRepositorioCliente repositorioCliente;
        IRepositorioTema repositorioTema;
        IRepositorioAluguel repositorioAluguel;
        TabelaAluguelControl tabelaAlugueis;

        public ContoladorAluguel(IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema, IRepositorioAluguel repositorioAluguel)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            this.repositorioAluguel = repositorioAluguel;
        }

        public override string ToolTipInserir => "Realizar novo aluguel";

        public override string ToolTipEditar => "Editar aluguel existente";

        public override string ToolTipExcluir => "Excluir aluguel existente";

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;

        public override void Inserir()
        {
            if (CarregarClientes().Count() == 0)
            {
                MessageBox.Show($"Você deve cadastrar um cliente para poder realizar um aluguel!",
                    "Inserção de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (CarregarTemas().Count() == 0)
            {
                MessageBox.Show($"Você deve cadastrar um tema para poder realizar um aluguel!",
                    "Inserção de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm tela = new(CarregarClientes(),CarregarTemas());

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = tela.ObterAluguel();

                repositorioAluguel.Inserir(aluguel);

                CarregarAlugueis();
            }
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

            TelaAluguelForm tela = new(CarregarClientes(), CarregarTemas());

            tela.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = tela.ObterAluguel();

                repositorioAluguel.Editar(aluguelSelecionado, aluguel);
            }

            CarregarTemas();
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

            DialogResult opcaoEscolhida =
                MessageBox.Show($"Deseja excluir o aluguel {aluguelSelecionado.id}?",
                "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Excluir(aluguelSelecionado);
                aluguelSelecionado.cliente.qtdAlugueisRealizados--;
            }

            CarregarAlugueis();
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

        private List<Cliente> CarregarClientes()
        {
            return repositorioCliente.SelecionarTodos();
        }

        private List<Tema> CarregarTemas()
        {
            return repositorioTema.SelecionarTodos();
        }
    }
}
