using System;

namespace Tabuada___For_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tabuada - For 1078
            //Biel Steve

            //Declaração de variaveis
            int n;

            Console.WriteLine("Digite o valor da multiplicação : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine(i + " x " + n + " = " + resultado);
            }
            Console.ReadLine();
        }
    }
}
