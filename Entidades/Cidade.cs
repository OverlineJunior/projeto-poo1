using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    internal class Cidade : Cadastrado
    {
        public string nome { private set; get; } = "";
        public string ddd { private set; get; } = "";
        public Estado estado { private set; get; } = new Estado();
    }
}
