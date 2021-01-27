using System;

namespace Matriz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 5
            //Biel Steve

            int n, m;

            Console.WriteLine("Digite quantas linhas e colunas: ");
            string[] s = Console.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);

            int[,] a = new int[n, m];
            int[,] b = new int[n, m];
            int[,] c = new int[n, m];


            Console.WriteLine("Digite os valores A: ");
            for (int i=0; i<n; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j=0; j<m; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("Digite os valores B: ");
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Valores da Matriz C : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();




        }
    }
}
