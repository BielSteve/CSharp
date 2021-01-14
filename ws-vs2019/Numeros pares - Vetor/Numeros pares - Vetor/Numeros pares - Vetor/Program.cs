using System;

namespace Numeros_pares___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numeros pares - Vetor
            //Biel Steve

            int n;

            Console.WriteLine("Digite quantas repetições: ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            Console.WriteLine("Digite os numeros : ");
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(s[i]);
            }

            int cont = 0;
            //para cada elemento x dentro do vetor numeros faça
            foreach (int x in numeros)
            {
                if (x % 2 == 0)
                {
                    Console.Write(x + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade: " + cont);

            Console.ReadLine();
        }
    }
}
