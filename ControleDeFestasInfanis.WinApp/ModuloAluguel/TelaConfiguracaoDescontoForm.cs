using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaConfiguracaoDescontoForm : Form
    {
        Desconto desconto { get; set; }

        public TelaConfiguracaoDescontoForm()
        {
            InitializeComponent();
        }

        public void ConfigurarTela(Desconto desconto)
        {
            numPorcentagemDesconto.Value = desconto.porcentagemDesconto;
            numDescontoMaximo.Value = desconto.porcentagemDescontoMaximo;

            this.desconto = desconto;
        }

        public void ObterDesconto()
        {

        }
    }
}
