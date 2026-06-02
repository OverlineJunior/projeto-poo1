using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Test.Forms.Cadastros;

namespace Test.Forms.Consultas
{
    public partial class ConsultaPaises : Test.Consulta
    {
        private CadastroPais cadastro;

        public ConsultaPaises(CadastroPais cadastro)
        {
            this.cadastro = cadastro;
            InitializeComponent();
        }
    }
}
