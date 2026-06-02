using System;

namespace Test
{
    public partial class Consulta : Base
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public virtual void Incluir()
        {

        }

        public virtual void Alterar()
        {

        }

        public virtual void Excluir()
        {

        }

        public virtual void Pesquisar()
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
