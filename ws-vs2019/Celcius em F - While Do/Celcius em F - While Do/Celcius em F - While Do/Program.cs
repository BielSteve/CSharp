using System;
using System.Globalization;

namespace Celcius_em_F___While_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            //Celcius em F - While Do
            //Biel Steve

            //Declaração de variaveis
            double C, F;
            char repetir;

            do{
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

            Console.ReadLine();

        }
    }
}
