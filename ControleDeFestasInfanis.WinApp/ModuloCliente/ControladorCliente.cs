using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;
        private TabelaAlugueisClienteControl tabelaAlugueisCliente;

        public ControladorCliente(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir novo cliente"; } }
        public override string ToolTipEditar { get { return "Editar cliente existente"; } }
        public override string ToolTipExcluir { get { return "Excluir cliente existente"; } }
        public override string ToolTipVisualizar { get { return "Visualizar historico de augueis de um cliente existente"; } }

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool SeparadorVisivel5 => true;
        public override bool VisualizarHabilitado => true;
        public override bool VisualizarVisivel => true;

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new(repositorioCliente.SelecionarTodos());

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Inserir(cliente);

                CarregarClientes();
            }
        }

        public override void Editar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm tela = new(repositorioCliente.SelecionarTodos());

            tela.ConfigurarTela(clienteSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = tela.ObterCliente();

                repositorioCliente.Editar(clienteSelecionado, cliente);

                CarregarClientes();
            }
        }

        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Exclusão de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (repositorioAluguel.SelecionarTodos().Any(x => x.cliente == cliente))
            {
                MessageBox.Show($"Não é possivel remover esse cliente pois ele possuí vinculo com ao menos um Aluguel!",
                    "Exclusão de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de clientes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);

                CarregarClientes();
            }
        }

        public override void Visualizar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Visalização de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            CarregarAlugueisCliente(clienteSelecionado);

            if (clienteSelecionado.alugueisCliente.Count() == 0)
            {
                MessageBox.Show($"Esse cliente não possuí alugueis!",
                    "Visalização de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (tabelaAlugueisCliente == null)
                tabelaAlugueisCliente = new TabelaAlugueisClienteControl();

            tabelaAlugueisCliente.AtualizarRegistros(clienteSelecionado.alugueisCliente);

            TelaAlugueisClienteForm tela = new(tabelaAlugueisCliente);
            tela.ShowDialog();
        }

        private void CarregarAlugueisCliente(Cliente clienteSelecionado)
        {
            foreach (Aluguel aluguel in repositorioAluguel.SelecionarTodos())
            {
                if (aluguel.cliente == clienteSelecionado)
                {
                    if (clienteSelecionado.alugueisCliente.Any(x => x == aluguel))
                        continue;

                    clienteSelecionado.alugueisCliente.Add(aluguel);
                }
            }
        }

        private void CarregarClientes()
        {
            List<Cliente> cliente = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(cliente);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterNumeroClienteSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }
    }
}
