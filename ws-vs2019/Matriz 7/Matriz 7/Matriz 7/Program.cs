using System;

namespace Matriz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 7
            //Biel Steve

            int m, n;

            Console.WriteLine("Digite quantas linhas e quantos soldados: ");
            string[] s = Console.ReadLine().Split(' ');
            m = int.Parse(s[0]);
            n = int.Parse(s[1]);

            int[,] mat = new int[m, n];

            Console.WriteLine("Digite os valores: ");

            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Digite a linha que quer fazer o gira: ");
            int fila = int.Parse(Console.ReadLine());

            // como nossa matriz comeca na linha 0, vamos decrementar o valor da fila
            fila = fila - 1;

            // passo 1: vamos salvar o ultimo da fila escolhida
            int ultimoDaFila = mat[fila, n - 1];

            // passo 2: vamos mover todos da fila (menos o ultimo) para a direita,
            // mas teremos que fazer isso da direita para a esquerda (contagem decrescente)
            for (int j = n - 1; j > 0; j--)//4
            {
                mat[fila, j] = mat[fila, j - 1];
            }

            // passo 3: agora vamos armazenar o ultimo na primeira posicao da fila
            mat[fila, 0] = ultimoDaFila;

            // pronto! Agora vamos imprimir a matriz alterada:
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
