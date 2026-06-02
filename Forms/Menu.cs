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

        private void BtnCadastrosPaises_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaPaises();
        }

        private void BtnCadastrosEstados_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaEstados();
        }

        private void BtnCadastrosCidades_Click(object sender, EventArgs e)
        {
            interfaces.ExibirConsultaCidades();
        }
    }
}
