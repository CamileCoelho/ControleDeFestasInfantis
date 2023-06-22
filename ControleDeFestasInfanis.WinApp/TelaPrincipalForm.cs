using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using ControleDeFestasInfantis.Infra.Json.ModuloCliente;
using ControleDeFestasInfantis.Infra.Json.ModuloFesta;
using ControleDeFestasInfantis.Infra.Json.ModuloItem;
using ControleDeFestasInfantis.Infra.Json.ModuloTema;
using ControleDeFestasInfantis.WinApp.ModuloCliente;
using ControleDeFestasInfantis.WinApp.ModuloAluguel;
using ControleDeFestasInfantis.WinApp.ModuloItem;
using ControleDeFestasInfantis.WinApp.ModuloTema;

namespace ControleDeFestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        static ContextoDeDados contextoDeDados = new(carregarDados: true);

        private IRepositorioCliente repositorioCliente = new RepositorioClienteArquivo(contextoDeDados);
        private IRepositorioAluguel repositorioAluguel = new RepositorioAluguelArquivo(contextoDeDados);
        private IRepositorioItem repositorioItem = new RepositorioItemArquivo(contextoDeDados);
        private IRepositorioTema repositorioTema = new RepositorioTemaArquivo(contextoDeDados);

        public TelaPrincipalForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

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
            controlador = new ControladorCliente(repositorioAluguel, repositorioCliente);

            ConfigurarTelaPrincipal(controlador);
        }

        private void alugueisMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ContoladorAluguel(repositorioCliente, repositorioTema, repositorioAluguel);

            ConfigurarTelaPrincipal(controlador);
        }

        private void itensParaLocaçãoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem(repositorioTema, repositorioItem);

            ConfigurarTelaPrincipal(controlador);
        }

        private void temasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioAluguel, repositorioItem, repositorioTema);

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
            btnRemoverItens.ToolTipText = controlador.ToolTipRemoverItens;
            btnConfigDesconto.ToolTipText = controlador.ToolTipFinalizarPagamento;
            btnConfigDesconto.ToolTipText = controlador.ToolTipConfigDesconto;
            btnVisualizar.ToolTipText = controlador.ToolTipVisualizar;

            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnRemoverItens.Enabled = controlador.RemoverItensHabilitado;
            btnFinalizarPgto.Enabled = controlador.FinalizarPagamentoHabilitado;
            btnConfigDesconto.Enabled = controlador.ConfigDescontoHabilitado;
            btnVisualizar.Enabled = controlador.VisualizarHabilitado;

            btnInserir.Visible = controlador.InserirVisivel;
            btnEditar.Visible = controlador.EditarVisivel;
            btnExcluir.Visible = controlador.ExcluirVisivel;
            btnFiltrar.Visible = controlador.FiltrarVisivel;
            btnAdicionarItens.Visible = controlador.AdicionarItensVisivel;
            btnRemoverItens.Visible = controlador.RemoverItensVisivel;
            btnFinalizarPgto.Visible = controlador.FinalizarPagamentoVisivel;
            btnConfigDesconto.Visible = controlador.ConfigDescontoVisivel;
            btnVisualizar.Visible = controlador.VisualizarVisivel;

            toolStripSeparator1.Visible = controlador.SeparadorVisivel1;
            toolStripSeparator2.Visible = controlador.SeparadorVisivel2;
            toolStripSeparator3.Visible = controlador.SeparadorVisivel3;
            toolStripSeparator4.Visible = controlador.SeparadorVisivel4;
            toolStripSeparator5.Visible = controlador.SeparadorVisivel5;
            toolStripSeparator6.Visible = controlador.SeparadorVisivel6;
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
            controlador.RemoverItens();
        }

        private void btnFinalizarPgto_Click(object sender, EventArgs e)
        {
            controlador.FinalizarPagamento();
        }

        private void btnConfigDesconto_Click(object sender, EventArgs e)
        {
            controlador.ConfigurarDesconto();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            controlador.Visualizar();
        }
    }
}