using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaFiltroAluguelForm : Form
    {
        public TelaFiltroAluguelForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public StatusAluguelEnum ObterFiltroAluguel()
        {
            if (rdbFinalizados.Checked == true)
                return StatusAluguelEnum.Finalizado;

            else if (rdbEmAndamento.Checked == true)
                return StatusAluguelEnum.Em_andamento;

            return StatusAluguelEnum.Todos;
        }
    }
}

