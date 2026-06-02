using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Forms.Consultas;

namespace Test.Entidades
{
    internal class Cidade : Cadastrado
    {
        public string nome { private set; get; } = "";
        public string ddd { private set; get; } = "";
        public Estado estado { private set; get; } = new Estado();

        public Cidade() { }

        public Cidade(
            string nome,
            string ddd,
            Estado estado,
            int codigo,
            int codigoUsuario,
            DateTime dataCadastro,
            DateTime dataUltimaAlteracao
        ) : base(codigo, codigoUsuario, dataCadastro, dataUltimaAlteracao)
        {
            this.nome = nome;
            this.ddd = ddd;
            this.estado = estado;
        }

        public Cidade Clonar()
        {
            return new Cidade(
                this.nome,
                this.ddd,
                this.estado.Clonar(),
                this.codigo,
                this.codigoUsuario,
                this.dataCadastro,
                this.dataUltimaAlteracao
            );
        }
    }
}
