using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaVisualizarCliente : UserControl
    {
        public TabelaVisualizarCliente()
        {
            InitializeComponent();

            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Alugueis", HeaderText = "Alugueis"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Pagamento", HeaderText = "Pagamento"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status"}
            };

            return colunas;
        }

        public int ObterClienteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (var cliente in clientes)
            {
                grid.Rows.Add(cliente.id, cliente.nome, cliente.qtdAlugueisRealizados, cliente.telefone);
                   
            }
        }
    }
}