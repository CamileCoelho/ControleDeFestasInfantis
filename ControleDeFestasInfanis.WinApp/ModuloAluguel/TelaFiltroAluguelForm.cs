using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaFiltroAluguelForm : Form
    {
        public TelaFiltroAluguelForm()
        {
            InitializeComponent();
        }

        public StatusAluguelEnum ObterFiltroAluguel()
        {
            if (rdbConcluidas.Checked == true)
                return StatusAluguelEnum.Finalizado;

            else if (rdbPendentes.Checked == true)
                return StatusAluguelEnum.Em_andamento;

            return StatusAluguelEnum.Todos;
        }
    }
}
