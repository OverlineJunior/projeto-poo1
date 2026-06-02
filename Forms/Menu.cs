using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Menu : Form
    {
        private Interfaces interfaces = new Interfaces();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnConsultasPaises_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaPaises();
        }

        private void btnConsultasEstados_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaEstados();
        }

        private void btnConsultasCidades_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaCidades();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
