using System;

namespace Matriz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 3
            //Biel Steve

            int n;

            Console.WriteLine("Digite quantidade de linhas e colunas: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine("Digite os valores: ");

            for (int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Maiores de cada linha : ");
            
            for (int i = 0; i < n; i++)
            {
                int maior = 0;
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }

            Console.ReadLine();



        }
    }
}
