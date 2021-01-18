using System;
using System.Globalization;

namespace Vetor_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor 5
            //Biel Steve

            int n, cont=0;
            double soma = 0.0;

            Console.WriteLine("Digite a quantidade de repetições: ");
            n = int.Parse(Console.ReadLine());

            double[] a = new double[n];

            Console.WriteLine("Digite os valores: ");
            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            foreach (double x in a)
            {
                if (x % 2 == 0)
                {
                    soma = soma + x;
                    cont++;
                }
            }

            double media = soma / cont;

            Console.WriteLine("Media : " + media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
