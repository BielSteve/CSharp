using System;
using System.Globalization;
namespace Positivos_e_Média___IF_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            //Positivos e Média - IF 1064

            //Declaração de variaveis
            double v1, v2, v3, v4, v5, v6, soma = 0, x = 0, media;

            Console.WriteLine("Digite 6 valores: ");
            v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (v1 > 0)
            {
                x = x + 1;
                soma = soma + v1;
            }
            if (v2 > 0)
            {
                x = x + 1;
                soma = soma + v2;

            }
            if (v3 > 0)
            {
                x = x + 1;
                soma = soma + v3;
            }
            if (v4 > 0)
            {
                x = x + 1;
                soma = soma + v4;
            }
            if (v5 > 0)
            {
                x = x + 1;
                soma = soma + v5;
            }
            if (v6 > 0)
            {
                x = x + 1;
                soma = soma + v6;
            }

            media = soma / x;

            Console.WriteLine(x + " Valores positivos");
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
