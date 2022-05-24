using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pecas;
            double valorTotal;

            pecas = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(pecas[0]);
            int qtdPeca1 = int.Parse(pecas[1]);
            double valorPeca1 = double.Parse(pecas[2], CultureInfo.InvariantCulture);

            pecas = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(pecas[0]);
            int qtdPeca2 = int.Parse(pecas[1]);
            double valorPeca2 = double.Parse(pecas[2], CultureInfo.InvariantCulture);

            valorTotal = qtdPeca1 * valorPeca1 + qtdPeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
