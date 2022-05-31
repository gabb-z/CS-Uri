using System;

namespace Uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maior;

            string[] numeros = Console.ReadLine().Split(' ');

            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            c = int.Parse(numeros[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
