using System;
using System.Globalization;

namespace Uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempoViagem, velocidadeMedia, litrosNecessarios;

            tempoViagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            litrosNecessarios = tempoViagem * velocidadeMedia / 12;

            Console.WriteLine(litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
