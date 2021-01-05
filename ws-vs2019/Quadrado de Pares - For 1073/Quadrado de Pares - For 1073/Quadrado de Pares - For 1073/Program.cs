using System;

namespace Quadrado_de_Pares___For_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quadrado de Pares - For 1073
            //Biel Steve

            //Declaração de variaveis
            int N, result;

            Console.WriteLine("Digite um valor: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    result = i * i;
                    Console.WriteLine(i + "^2 = " + result);
                }
            }

            Console.ReadLine();




        }
    }
}
