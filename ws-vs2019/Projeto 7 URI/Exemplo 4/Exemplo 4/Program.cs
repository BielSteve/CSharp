using System;
using System.Globalization;

namespace Exemplo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double A, B, MEDIA;

            Console.WriteLine("Digite a nota 1:");
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 2:");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (A + B) / 2;

            Console.WriteLine(" MEDIA = " + MEDIA.ToString( "F5", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
