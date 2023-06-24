using ControleDeFestasInfantis.Dominio.ModuloAluguel;

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
            if (rdbConcluidas.Checked)
            {
                return StatusAluguelEnum.Finalizado;
            }
            else if (rdbPendentes.Checked)
            {
                return StatusAluguelEnum.Em_andamento;
            }
            else
            {
                return StatusAluguelEnum.Todos;
            }
        }
    }
}
