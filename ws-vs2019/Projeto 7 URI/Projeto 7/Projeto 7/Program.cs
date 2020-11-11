using System;
using System.Globalization;

namespace Projeto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            double area, raio, n, a;

            n = 3.14159;

            Console.WriteLine("Digite o valor da raio:");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            a = Math.Pow(raio, 2.0);

            area = n * a;

            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
