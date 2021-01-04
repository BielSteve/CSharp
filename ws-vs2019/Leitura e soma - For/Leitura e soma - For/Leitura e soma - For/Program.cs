using System;

namespace Leitura_e_soma___For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura e soma - For
            //Biel Steve

            //Declaração de variaveis
            int n, x, soma = 0;

            Console.WriteLine("Digite quantos valores você quer somar otario: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite o valor: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine("A soma de todos os valores é : " + soma);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor : " + i);
            }
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Valor : " + i);
            }
            Console.ReadLine();
        }
    }
}
