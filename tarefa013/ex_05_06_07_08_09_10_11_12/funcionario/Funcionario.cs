using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Funcionario
    {
        public string Nome;
        long CodigoFuncional;
        public EnumComissoes Comissao;

        public Funcionario(string nome, EnumComissoes comissao)
        {
            this.Comissao = comissao;
            this.Nome = nome;
        }

        public static double RendaBase()
        {
            return 1000;
        }
        public virtual double RendaTotal()
        {
            return RendaBase() + (double)Comissao;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Comissão: R$ {((double)Comissao):n2}, Salário Total: {this.RendaTotal():n2} \n";
        }

    }
}
