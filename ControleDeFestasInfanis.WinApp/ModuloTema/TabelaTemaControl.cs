using ControleDeFestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total", HeaderText = "Valor Total"},

            };

            return colunas;
        }

        public int ObterNumeroTemaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();

            foreach (var tema in temas)
            {
                grid.Rows.Add(tema.id, tema.titulo, tema.valorTotal);
            }
        }
    }
}