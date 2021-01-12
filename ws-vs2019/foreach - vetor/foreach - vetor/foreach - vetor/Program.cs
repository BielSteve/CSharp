using System;

namespace foreach___vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach - vetor
            //Biel Steve


            //Declaração de variaveis
            int n;

            Console.WriteLine("Digite quantas repetições: ");
            n = int.Parse(Console.ReadLine());

            string[] vet = new string[n];

            Console.WriteLine("Digite os nomes : ");
            //Para cada Elemento X dentro do vetor vet  faça:
            // in = dentro de
            //foreach = Para cada

            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }

            foreach(string x in vet)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
