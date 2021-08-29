using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class FuncionarioEMedio : FuncionarioEBasico
    {
        public override double RendaTotal()
        {
            FuncionarioEBasico funcionario = new();
            return funcionario.RendaTotal() * 1.5;
        }
    }
}
