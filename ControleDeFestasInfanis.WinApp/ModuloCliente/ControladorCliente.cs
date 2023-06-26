﻿using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using ControleDeFestasInfantis.WinApp.ModuloTema;
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

        public override string ToolTipInserir => "Inserir novo cliente"; 
        public override string ToolTipEditar => "Editar cliente existente"; 
        public override string ToolTipExcluir => "Excluir cliente existente"; 
        public override string ToolTipVisualizar => "Visualizar historico de alugueis de um cliente existente"; 
        public override string ToolTipHome => "Voltar a tela inicial"; 

        public override bool HomeHabilitado => true;
        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool SeparadorVisivel4 => true;
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

            TelaAlugueisClienteForm tela = new(tabelaAlugueisCliente, clienteSelecionado);
            tela.ShowDialog();
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

        private void CarregarClientes()
        {
            List<Cliente> cliente = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(cliente);
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterNumeroClienteSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }
    }
}
