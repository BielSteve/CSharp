using System;

namespace Pares_entre_Cinco_Números___IF_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pares entre Cinco Números - IF 1065

            //Declaração de variaveis
            int v1, v2, v3, v4, v5, x = 0;

            Console.WriteLine("Digite 5 valores: ");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            v3 = int.Parse(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());
            v5 = int.Parse(Console.ReadLine());


            if (v1 % 2 == 0)
            {
                x = x + 1;
            }
            if (v2 % 2 == 0)
            {
                x = x + 1;
            }
            if (v3 % 2 == 0)
            {
                x = x + 1;
            }
            if (v4 % 2 == 0)
            {
                x = x + 1;
            }
            if (v5 % 2 == 0)
            {
                x = x + 1;
            }

            Console.WriteLine(x + " Valores pares");

            Console.ReadLine();

        }
    }
}
