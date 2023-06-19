using ControleDeFestasInfantis.Dominio.ModuloTema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema { get; set; }
        private List<Tema> temas { get; set; }

        public TelaTemaForm(List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.temas = temas;
        }

        public Tema ObterTema()
        {
            string titulo = txtTema.Text;

            return new Tema(titulo);
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.titulo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tema = ObterTema();

            string status = "";

            if (temas.Any(x => x.titulo == tema.titulo))
                status = "Já existe um tema cadastrado com esse titulo!";
            else
                status = tema.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
