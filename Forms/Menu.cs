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

        private void btnCadastrosPaises_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaPaises();
        }

        private void btnCadastrosEstados_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaEstados();
        }

        private void btnCadastrosCidades_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaCidades();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
