using System;

namespace Mostrar_Numeros_Negativos___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar Numeros Negativos - Vetor
            //Biel Steve


            //Declaração de variaveis
            int n;
            int[] vet;

            Console.WriteLine("Digite quantas posições terá o seu vetor : ");
            n = int.Parse(Console.ReadLine());

            //Criação de vetores
            vet = new int[n];

            Console.WriteLine("Digite os valores : ");
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            Console.WriteLine("Valores negativos: ");
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }

            Console.ReadLine();


        }
    }
}
