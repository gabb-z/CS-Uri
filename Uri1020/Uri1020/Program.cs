using System;

namespace Uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeDias, ano, mes, cont, resto;

            idadeDias = int.Parse(Console.ReadLine());

            resto = idadeDias;

            ano = 365;
            cont = resto / ano;
            resto = resto % ano;

            Console.WriteLine(cont + " ano(s)");

            mes = 30;
            cont = resto / mes;
            resto = resto % mes;

            Console.WriteLine(cont + " mes(es)");
            Console.WriteLine(resto + " dia(s)");
        }
    }
}
