using System;
using System.Globalization;

namespace Vetor_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor 7
            //Biel Steve

            int n;
            Console.WriteLine("Digite a quantidade de repetições: "); ;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] notas1 = new double[n];
            double[] notas2 = new double[n];

            Console.WriteLine("Digite os nomes e as notas: ");

            for (int i=0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                notas1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }


            double media = 0.0;
            Console.WriteLine("Nome dos Aprovados: ");
            for (int i=0; i<n; i++)
            {
                media = (notas1[i] + notas2[i]) / 2.0 ;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

            Console.ReadLine();

        }
    }
}
