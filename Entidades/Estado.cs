using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    internal class Estado : Cadastrado
    {
        public string nome { private set; get; } = "";
        public string uf { private set; get; } = "";
        public Pais pais { private set; get; } = new Pais();

        public Estado() { }

        public Estado(
            string nome,
            string uf,
            Pais pais,
            int codigo,
            int codigoUsuario,
            DateTime dataCadastro,
            DateTime dataUltimaAlteracao
        ) : base(codigo, codigoUsuario, dataCadastro, dataUltimaAlteracao)
        {
            this.nome = nome;
            this.uf = uf;
            this.pais = pais;
        }

        public Estado Clonar()
        {
            return new Estado(
                this.nome,
                this.uf,
                this.pais.Clonar(),
                this.codigo,
                this.codigoUsuario,
                this.dataCadastro,
                this.dataUltimaAlteracao
            );
        }
    }
}
