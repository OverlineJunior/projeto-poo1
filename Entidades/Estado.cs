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
    }
}
