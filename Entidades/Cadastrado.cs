using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    internal abstract class Cadastrado
    {
        public int codigo { protected set; get; } = 0;
        public int codigoUsuario { protected set; get; } = 0;
        public DateTime? dataCadastro { protected set; get; } = null;
        public DateTime? dataUltimaAlteracao { protected set; get; } = null;
    }
}
