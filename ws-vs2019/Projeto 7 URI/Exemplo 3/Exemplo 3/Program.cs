using System;

namespace Exemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, PROD;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine( "PROD = " + PROD);

            Console.ReadLine();
        }
    }
}
