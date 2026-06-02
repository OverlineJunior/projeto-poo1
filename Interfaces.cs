using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Forms.Consultas;

namespace Test
{
    internal class Interfaces
    {
        private ConsultaPaises consultaPaises = new ConsultaPaises();
        private ConsultaEstados consultaEstados = new ConsultaEstados();
        private ConsultaCidades consultaCidades = new ConsultaCidades();

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
