using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo;
            double vendasTotais;
            double salarioComissao;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasTotais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioComissao = salarioFixo + (15 * vendasTotais / 100);

            Console.WriteLine("TOTAL = R$ " + salarioComissao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
