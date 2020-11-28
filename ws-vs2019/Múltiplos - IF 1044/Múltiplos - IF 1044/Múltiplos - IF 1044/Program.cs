using System;

namespace Múltiplos___IF_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            //Múltiplos - IF 1044

            //Declaração de variaveis
            int A, B;

            Console.WriteLine("Digite dois valores na mesma linha: ");
            String[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0 )
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Não Sao Multiplos");
            }
            Console.ReadLine();

        }
    }
}
