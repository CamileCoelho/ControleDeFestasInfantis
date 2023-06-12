using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;
using System.Xml.Linq;

namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        // private Tema tema { get; set; }
        public TelaTemaForm(List<Item> itens)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarItens(itens);

        }

        private void CarregarItens(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                cmbItem.Items.Add(item);
            }
        }

        public Tema ObterTema()
        {
           int id = Convert.ToInt32(txtId);

            string nome = txtTema.Text;

            Item item = (Item)cmbItem.SelectedItem;

            Tema tema = new Tema(id, nome, item);

            if (id > 0)
                tema.id = id;


            return tema;
        }


        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.nome;

            cmbItem.SelectedItem = temaSelecionado.item;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();
            string status = tema.Validar();

            if (status.Length > 0)

                TelaPrincipalForm.Tela.AtualizarRodape(status);
                
                DialogResult = DialogResult.None;
        }



        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
