using System;
using System.Globalization;

namespace Matriz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 6
            //Biel Steve

            int n;

            Console.WriteLine("Digite a quantidade linhas e colunas: ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            Console.WriteLine("Digite os valores : ");
            for (int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++)
                {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            
            double soma = 0.0; ;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] > 0)
                    {
                        soma = soma + mat[i, j];
                    }
                }
            }

            int linha;
            Console.WriteLine("Escolha a linha: ");
            linha = int.Parse(Console.ReadLine());
            int coluna;
            Console.WriteLine("Escolha a coluna: ");
            coluna = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultados: ");
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < n; j++)
            {
                    Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");

            }
            Console.WriteLine();
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = coluna; j < n; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL : ");
            for (int i = 0; i < n; i++)
            {
                
                    Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0.0)
                    {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
