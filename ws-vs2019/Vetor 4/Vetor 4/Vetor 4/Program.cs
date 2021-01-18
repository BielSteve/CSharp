using System;
using System.Globalization;

namespace Vetor_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor 4
            //Biel Steve

            int n;
            double soma = 0.0, media;

            Console.WriteLine("Digite a quantidade de repetições: ");
            n = int.Parse(Console.ReadLine());

            double[] a = new double[n];

            Console.WriteLine("Digite os valores: ");
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma = soma + a[i];
            }

            media = soma / n;
            Console.WriteLine("Media : " + media.ToString("F3", CultureInfo.InvariantCulture));
            for (int i = 0; i < n; i++)
            {
                if (a[i] < media)
                {
                    Console.WriteLine("Abaixo da media: " + a[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();
        }
    }
}
