using System;
using System.Globalization;

namespace Exemplo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double A, B, C, MEDIA;

            Console.WriteLine("Digite a nota 1:");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 2:");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 3:");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (A * 2 + B * 3 + C * 5) / 10 ;

            Console.WriteLine( " MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
