using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema { get; set; }
        private Tema temaSelecionado { get; set; }
        private List<Tema> temas { get; set; }

        public TelaTemaForm(List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.temas = temas;
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtTema.Text.Trim();

            return new Tema(id, titulo);
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.titulo;

            this.temaSelecionado = temaSelecionado;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tema = ObterTema();
            string status = "";

            if (temas.Where(i => tema.id != temaSelecionado?.id).Any(x => x.titulo == tema.titulo))
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
