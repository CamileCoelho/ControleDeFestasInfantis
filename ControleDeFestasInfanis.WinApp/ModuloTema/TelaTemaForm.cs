using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema { get; set; }

        private List<Tema> listaTemas;

        public TelaTemaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
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

            string status = tema.Validar();

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
