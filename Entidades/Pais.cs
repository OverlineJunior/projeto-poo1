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
    }
}
