using System;
using System.Globalization;

namespace Uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaKm;
            double combustivelGasto, kmLitro;

            distanciaKm = int.Parse(Console.ReadLine());
            combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kmLitro = distanciaKm * combustivelGasto;

            Console.WriteLine(kmLitro.ToString("F3", CultureInfo.InvariantCulture) + "km/l");

        }
    }
}
