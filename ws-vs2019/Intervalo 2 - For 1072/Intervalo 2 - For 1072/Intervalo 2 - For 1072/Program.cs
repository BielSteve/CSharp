using System;

namespace Intervalo_2___For_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intervalo 2 - For 1072
            //Biel Steve

            //Declaração de variaveis
            int N, inn = 0, outt = 0, x;

            Console.WriteLine("Digite quantos valores serão lidos: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um valor: ");
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    inn++;
                }
                else
                {
                    outt++;
                }
            }
            Console.WriteLine(inn + " in");
            Console.WriteLine(outt + " out");

            Console.ReadLine();


        }
    }
}
