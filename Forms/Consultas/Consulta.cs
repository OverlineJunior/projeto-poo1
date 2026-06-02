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

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
