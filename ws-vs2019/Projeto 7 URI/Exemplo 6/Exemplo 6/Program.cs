using System;

namespace Exemplo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            int A, B, C, D, DIFERENCA;

            Console.WriteLine("Digite o valor 1 :");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2 :");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 3 :");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 4 :");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine( "DIFERENCA = " + DIFERENCA);

            Console.ReadLine();

        }
    }
}
