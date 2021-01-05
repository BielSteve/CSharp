using System;

namespace Maior_e_Posição___For_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maior e Posição - For 1080
            //Biel Steve


            //Declaração  de variaveis
            int N = 5, x, posicao = 0, maior = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite um valor: ");
                x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }
            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Posição " + posicao);

            Console.ReadLine();



        }
    }
}
