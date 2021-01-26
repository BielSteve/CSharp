using System;

namespace Matriz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 4
            //Biel Steve

            int n;

            Console.WriteLine("Digite a quantidade de linhas e colunas: ");
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

            Console.WriteLine("Resultado: ");
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                { // j inicia com i+1 para que ele possa ser incrementado a cada repetição e pegue o proximo valor apos a diagonal
                    soma = soma + mat[i, j];
                }
            }


            Console.WriteLine(soma);


            Console.ReadLine();




        }
    }
}
