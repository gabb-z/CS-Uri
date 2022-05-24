using System;
using System.Globalization;

namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionario;
            int horasTrabalhadas;
            double salarioHora;
            double salarioTotal;

            numFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioTotal = salarioHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
