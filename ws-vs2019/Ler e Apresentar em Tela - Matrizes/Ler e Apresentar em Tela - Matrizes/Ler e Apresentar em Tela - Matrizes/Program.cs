using System;

namespace Ler_e_Apresentar_em_Tela___Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler e Apresentar em Tela - Matrizes
            //Biel Steve

            int n, m;

            Console.WriteLine("Digite quantas linhas e quantas colunas: ");
            string[] s = Console.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);

            int[,] a = new int[n, m];

            Console.WriteLine("Digite os valores: ");
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j<m; j++)
                {
                    a[i, j] = int.Parse(vet[j]);
                }
            }
            Console.WriteLine("Resultado: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
