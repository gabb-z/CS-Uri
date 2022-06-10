using System;

namespace Uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, horas, minutos, segundos, resto;

            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
