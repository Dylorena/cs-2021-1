using System;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            double gastoTotal =  0;
            Funcionario[] funcionarios = new Funcionario[10];

            funcionarios[0] = new FuncionarioEMedio();
            funcionarios[1] = new FuncionarioEMedio();
            funcionarios[2] = new FuncionarioEMedio();
            funcionarios[3] = new FuncionarioEMedio();
            funcionarios[4] = new FuncionarioEBasico();
            funcionarios[5] = new FuncionarioEBasico();
            funcionarios[6] = new FuncionarioEBasico();
            funcionarios[7] = new FuncionarioEBasico();
            funcionarios[8] = new FuncionarioESuperior();
            funcionarios[9] = new FuncionarioESuperior();

            foreach(var fun in funcionarios)
            {
                gastoTotal += fun.RendaTotal();
            }

            Console.WriteLine($"Gasto total empresa exercício 07: {gastoTotal}");
        }
    }
}
