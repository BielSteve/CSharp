using System;

namespace Soma_de_Impares_Consecutivos_I___For_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma de Impares Consecutivos I - For 1071
            //Biel Steve

            //Declaração de variaveis
            int x, y, min, max, soma = 0;

            Console.WriteLine("Digite os valores de x e y : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
                
            }
            Console.WriteLine("Resultado: " + soma);
            Console.ReadLine();


        }
    }
}
