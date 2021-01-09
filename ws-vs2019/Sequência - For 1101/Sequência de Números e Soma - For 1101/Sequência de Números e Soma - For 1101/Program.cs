using System;

namespace Sequência_de_Números_e_Soma___For_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequência de Números e Soma - For 1101
            //Biel Steve

            //Declaração de variaveis
            int m, n;

            Console.WriteLine("Digite dois valores: ");
            string[] vet = Console.ReadLine().Split(' ');
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                int menor = m;
                int maior = n;
                if (m > n)
                {
                    menor = n;
                    maior = m;
                }
                int soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    soma = soma + i;
                    Console.Write(i + " ");
                }

                Console.WriteLine("Soma : " +soma);
                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
            }
            Console.ReadLine();



        }
    }
}
