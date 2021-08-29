using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class FuncionarioEBasico: Funcionario
    {
        string Escola;

        public override double RendaTotal()
        {
            return RendaBase() * 1.1;
        }
    }
}
