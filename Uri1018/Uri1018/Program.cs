using System;

namespace Uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contador, resto, nota;

            n = int.Parse(Console.ReadLine());

            Console.WriteLine(n);

            resto = n;

            nota = 100;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            contador = resto / nota;
            Console.WriteLine(contador + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;
        }
    }
}
