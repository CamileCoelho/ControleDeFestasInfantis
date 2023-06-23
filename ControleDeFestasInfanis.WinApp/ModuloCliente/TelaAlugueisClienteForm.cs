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
    public partial class TelaAlugueisClienteForm : Form
    {
        public TelaAlugueisClienteForm(TabelaAlugueisClienteControl tabelaAlugueisCliente)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            tabelaAlugueisCliente.Dock = DockStyle.Fill;

            panelAlugueisCliente.Controls.Clear();

            panelAlugueisCliente.Controls.Add(tabelaAlugueisCliente);
        }
    }
}
