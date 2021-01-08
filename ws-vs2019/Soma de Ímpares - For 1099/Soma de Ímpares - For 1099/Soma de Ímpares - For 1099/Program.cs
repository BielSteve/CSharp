using System;

namespace Soma_de_Ímpares___For_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma de Ímpares - For 1099
            //Biel Steve

            //Declaração de variaveis
            int n, x, y;

            Console.WriteLine("Digite quantas vezes deseja executar a repetição: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite dois valores: ");
                String[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                    }
                }
                

                Console.WriteLine("A soma dos impares entre X e Y é :" + soma);

            }
            Console.ReadLine();



        }
    }
}
