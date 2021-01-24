using System;

namespace Gerar_vetor_com_matriz___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerar_vetor_com_matriz
            //Biel Steve

            int n, m;

            Console.WriteLine("Digite as quantas linhas e colunas: ");
            string[] s = Console.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);

            int[,] mat = new int[n, m];

            Console.WriteLine("Digite os valores: ");
            for (int i=0; i<n; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j=0; j<m; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[n];
            
            for (int i=0; i<n; i++)
            {
                int soma = 0;
                for (int j=0; j<m; j++)
                {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
                Console.WriteLine("Vetor " + i + " tem o valor de : " + vet[i]);
            }

            
            Console.ReadLine();




        }
    }
}
