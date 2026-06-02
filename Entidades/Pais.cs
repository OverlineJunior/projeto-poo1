using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    internal class Pais : Cadastrado
    {
        public string nome { private set; get; } = "";
        public string sigla { private set; get; } = "";
        public string ddi { private set; get; } = "";
        public string moeda { private set; get; } = "";

        public Pais() { }

        public Pais(
            string nome,
            string sigla,
            string ddi,
            string moeda,
            int codigo,
            int codigoUsuario,
            DateTime dataCadastro,
            DateTime dataUltimaAlteracao
        ) : base(codigo, codigoUsuario, dataCadastro, dataUltimaAlteracao)
        {
            this.nome = nome;
            this.sigla = sigla;
            this.ddi = ddi;
            this.moeda = moeda;
        }

        public Pais Clonar()
        {
            return new Pais(
                this.nome,
                this.sigla,
                this.ddi,
                this.moeda,
                this.codigo,
                this.codigoUsuario,
                this.dataCadastro,
                this.dataUltimaAlteracao
            );
        }
    }
}
