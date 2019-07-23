using System;

namespace IRCalculator.IRConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario1 = 1800.58;
            double salario2 = 2000.25;
            double salario3 = 2999.30;
            double salario4 = 4005.00;
            double salario5 = 6357.66;

            new Domain.IRCalculator(salario1).CalculaSalario();
            new Domain.IRCalculator(salario2).CalculaSalario();
            new Domain.IRCalculator(salario3).CalculaSalario();
            new Domain.IRCalculator(salario4).CalculaSalario();
            new Domain.IRCalculator(salario5).CalculaSalario();

            Console.ReadLine();
        }
    }
}
