using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloFesta;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using ControleDeFestasInfantis.Infra.Json.ModuloCliente;
using ControleDeFestasInfantis.Infra.Json.ModuloFesta;
using ControleDeFestasInfantis.Infra.Json.ModuloItem;
using ControleDeFestasInfantis.Infra.Json.ModuloTema;
using ControleDeFestasInfantis.WinApp.ModuloCliente;
using ControleDeFestasInfantis.WinApp.ModuloFesta;
using ControleDeFestasInfantis.WinApp.ModuloItem;
using ControleDeFestasInfantis.WinApp.ModuloTema;

namespace ControleDeFestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        static ContextoDeDados contextoDeDados = new(carregarDados: true);

        private IRepositorioCliente repositorioCliente = new RepositorioClienteArquivo(contextoDeDados);
        private IRepositorioFesta repositorioFesta = new RepositorioFestaArquivo(contextoDeDados);
        private IRepositorioItem repositorioItem = new RepositorioItemArquivo(contextoDeDados);
        private IRepositorioTema repositorioTema = new RepositorioTemaArquivo(contextoDeDados);

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Tela = this;
        }

        public static TelaPrincipalForm Tela
        {
            get;
            private set;
        }

        public void AtualizarRodape(string status)
        {
            lableRodape.Text = status;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente();

            ConfigurarTelaPrincipal(controlador);
        }

        private void agendamentoDeFestaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ContoladorFesta();

            ConfigurarTelaPrincipal(controlador);
        }

        private void itensParaLocaçãoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem(repositorioItem);

            ConfigurarTelaPrincipal(controlador);
        }

        private void temasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema();

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoDoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;

            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItens();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            controlador.ConcluirItens();
        }
    }
}