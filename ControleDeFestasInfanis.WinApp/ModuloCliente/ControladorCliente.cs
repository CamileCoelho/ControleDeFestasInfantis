using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl listagemCliente;

        public ControladorCliente(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente)
        {
            this.repositorioAluguel = repositorioAluguel
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir novo contato"; } }

        public override string ToolTipEditar { get { return "Editar contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir contato existente"; } }

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new();

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                if (repositorioCliente.SelecionarTodos().Any(x => x.nome == cliente.nome))
                {
                    MessageBox.Show($"Já existe um cliente cadastrado com esse nome!",
                        "Inserção de clientes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }

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
            if (repositorioCliente.SelecionarTodos().Any(x => x.nome == clienteSelecionado.nome))
            {
                MessageBox.Show($"Já existe um cliente cadastrado com esse nome!",
                    "Edição de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm tela = new();

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
                MessageBox.Show($"Selecione um contato primeiro!",
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

        private void CarregarClientes()
        {
            List<Cliente> cliente = repositorioCliente.SelecionarTodos();

            listagemCliente.AtualizarRegistros(cliente);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCliente == null)
                listagemCliente = new TabelaClienteControl();

            CarregarClientes();

            return listagemCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = listagemCliente.ObterNumeroClienteSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }
    }
}
