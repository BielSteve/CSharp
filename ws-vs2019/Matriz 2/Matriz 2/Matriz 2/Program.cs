using System;

namespace Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 2
            //Biel Steve

            int n;

            Console.WriteLine("Digite a quantidade de linhas e colunas: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine("Digite os valores: ");

            for (int i = 0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Resultado: ");
            for (int i = 0; i < n; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine("Soma da linha " + i + " é : " + soma);
            }

            Console.ReadLine();


        }
    }
}
