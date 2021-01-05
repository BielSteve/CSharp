using System;

namespace Resto_2___For_1075
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resto 2 - For 1075
            //Biel Steve

            //Declaração de variaves
            int N;

            Console.WriteLine("Digite um valor: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 1000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


        }
    }
}
