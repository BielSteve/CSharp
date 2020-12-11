using System;
using System.Globalization;

namespace Números_Positivos___IF_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            //Números Positivos - IF 1060

            //declaração de variaveis
            double v1, v2, v3, v4, v5, v6, x = 0;


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
            }
            if (v2 > 0)
            {
                x = x + 1;
            }
            if (v3 > 0)
            {
                x = x + 1;
            }
            if (v4 > 0)
            {
                x = x + 1;
            }
            if (v5 > 0)
            {
                x = x + 1;
            }
            if (v6 > 0)
            {
                x = x + 1;
            }



            Console.WriteLine(x + " Valores Positivos");
            Console.ReadLine();
        }
    }
}
