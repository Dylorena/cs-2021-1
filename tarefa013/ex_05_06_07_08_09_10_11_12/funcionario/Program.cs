using System;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            double gastoTotal =  0;
            Funcionario[] funcionarios = new Funcionario[10];

            funcionarios[0] = new FuncionarioEMedio("Diana", EnumComissoes.Vendedor);
            funcionarios[1] = new FuncionarioEMedio("Luisa", EnumComissoes.Supervisor);
            funcionarios[2] = new FuncionarioEMedio("Bruno", EnumComissoes.Vendedor);
            funcionarios[3] = new FuncionarioEMedio("Geisa", EnumComissoes.Vendedor);
            funcionarios[4] = new FuncionarioEBasico("Raissa", EnumComissoes.Vendedor);
            funcionarios[5] = new FuncionarioEBasico("Marcos", EnumComissoes.Vendedor);
            funcionarios[6] = new FuncionarioEBasico("Ronaldo", EnumComissoes.Vendedor);
            funcionarios[7] = new FuncionarioEBasico("Rose", EnumComissoes.Vendedor);
            funcionarios[8] = new FuncionarioESuperior("Daiana", EnumComissoes.Supervisor);
            funcionarios[9] = new FuncionarioESuperior("Julia", EnumComissoes.Gerente);

            foreach(var fun in funcionarios)
            {
                gastoTotal += fun.RendaTotal();
                Console.WriteLine(fun.ToString());
            }

            Console.WriteLine($"Gasto total empresa exercício 07: {gastoTotal}");
        }
    }
}
