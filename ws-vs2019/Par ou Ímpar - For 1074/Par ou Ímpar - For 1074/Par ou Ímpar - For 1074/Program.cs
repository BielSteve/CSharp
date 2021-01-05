using System;

namespace Par_ou_Ímpar___For_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            //Par ou Ímpar - For 1074
            //Biel Steve


            //Declaração de variaveis
            int N, x;

            Console.WriteLine("Digite a quantidade de valores que serão lidos: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite o valor para leitura: ");
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0 && x > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x % 2 != 0 && x < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
            Console.ReadLine();
        



        }
    }
}
