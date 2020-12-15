using System;
using System.Globalization;

namespace Quadrante___While__1115
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quadrante - While  1115

            //Declaração de variaveis
            double x, y;

            Console.WriteLine("Digite os valores de X e Y Otario: ");
            String[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }

                vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);
            }

            Console.ReadLine();


        }
    }
}
