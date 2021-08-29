using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class FuncionarioESuperior : FuncionarioEMedio
    {
        public override double RendaTotal()
        {
            FuncionarioEMedio funcionario = new();
            return funcionario.RendaTotal() * 2;
        }
    }
}
