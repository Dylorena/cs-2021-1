using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Funcionario
    {
        string Nome;
        long CodigoFuncional;
        EnumComissoes Comissao;

        public static double RendaBase()
        {
            return 1000;
        }
        public virtual double RendaTotal()
        {
            return 1000;
        }

    }
}
