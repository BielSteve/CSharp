using System;

namespace Vetor_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor 6
            //Biel Steve

            int n, idade_velho=0;
            string nome_velho = "nulo";

            Console.WriteLine("Digite quantas repetições : ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            Console.WriteLine("Digite nome e idade : ");

            for (int i = 0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            for (int i=0; i<n; i++)
            {
                if (idades[i] > idade_velho)
                {
                    idade_velho = idades[i];
                    nome_velho = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha : " + nome_velho);

            Console.ReadLine();


        }
    }
}
