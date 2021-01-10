using System;

namespace Sequência_Lógica_2__for_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequência Lógica 2- for 1145
            //Biel Steve



            //Declaração de variaveis
            int x, y;

            Console.WriteLine("Digite dois valores para contagem: ");
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.ReadLine();

        }
    }
}
