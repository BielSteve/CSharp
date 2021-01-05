using System;

namespace Números_Ímpares___For_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            //Números Ímpares - For 1067
            //Biel Steve

            //Declaração de variaveis
            int x;

            Console.WriteLine("Digite um valor para pausar a leitura: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Impares : " + i);
                }
            }
            Console.ReadLine();
        }
    }
}
