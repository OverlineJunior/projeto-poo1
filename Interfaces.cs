using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Forms.Cadastros;
using Test.Forms.Consultas;

namespace Test
{
    internal class Interfaces
    {
        private ConsultaCidades consultaCidades;
        private ConsultaEstados consultaEstados;
        private ConsultaPaises consultaPaises;
        private CadastroCidade cadastroCidade;
        private CadastroEstado cadastroEstado;
        private CadastroPais cadastroPais;

        public Interfaces()
        {
            cadastroCidade = new CadastroCidade();
            cadastroEstado = new CadastroEstado();
            cadastroPais = new CadastroPais();
            consultaCidades = new ConsultaCidades(cadastroCidade);
            consultaEstados = new ConsultaEstados(cadastroEstado);
            consultaPaises = new ConsultaPaises(cadastroPais);
        }

        public void ExibirConsultaPaises()
        {
            consultaPaises.ShowDialog();
        }

        public void ExibirConsultaEstados()
        {
            consultaEstados.ShowDialog();
        }

        public void ExibirConsultaCidades()
        {
            consultaCidades.ShowDialog();
        }
    }
}
