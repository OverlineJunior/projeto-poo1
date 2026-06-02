using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test.Forms.Cadastros
{
    public partial class Cadastro : Test.Base
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public virtual void LimparCampos()
        {

        }

        public virtual void CarregarCampos()
        {

        }

        public virtual void BloquearCampos()
        {

        }

        public virtual void DesbloquearCampos()
        {

        }

        public void Salvar()
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
