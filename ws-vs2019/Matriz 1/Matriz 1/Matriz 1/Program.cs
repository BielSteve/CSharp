using System;

namespace Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 1
            //Biel Steve

            int n, m;

            Console.WriteLine("Digite quantas linhas e colunas: ");
            string[] s = Console.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);


            int[,] mat = new int[n, m];

            Console.WriteLine("Digite os valores: ");
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j=0; j<m; j++)
                {
                    mat[i, j] = int.Parse(s[j]); 
                }
            }

            Console.WriteLine("NUMEROS NEGATIVOS : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }

            Console.ReadLine();


        }
    }
}
