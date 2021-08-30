using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class FuncionarioEMedio : FuncionarioEBasico
    {
        public FuncionarioEMedio(string nome, EnumComissoes comissao) : base(nome, comissao)
        {
        }
        public override double RendaTotal()
        {
            return base.RendaTotal() * 1.5;
        }

    }
}
