using System;
using System.Globalization;

namespace Validação_de_Nota___While_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validação de Nota - While 1117

            //Declaração de variaveis

            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
