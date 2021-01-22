using System;
using System.Globalization;

namespace Vetor_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor 8
            //Biel Steve

            int n;

            Console.WriteLine("Digite a quantidade de repetições: ");
            n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexos = new char[n];

            Console.WriteLine("Digite a altura e o sexo(M ou F)");

            for (int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(s[1]); ;
            }

            double maior = 0.0, menor = alturas[0], soma = 0.0, media;
            int cont_f = 0, cont_m = 0;


            for (int i = 0; i < n; i++)
            {
                if (alturas[i] > maior)
                {
                    maior = alturas[i];
                }
                
                if (alturas[i] < menor)
                {
                    menor = alturas[i];
                }

                if (sexos[i] == 'F')
                {
                    soma = soma + alturas[i];
                    cont_f++;
                }
               
                if (sexos[i] == 'M')
                {
                    cont_m++;
                }
            }

            media = soma / cont_f;

            Console.WriteLine("Menor altura: " + menor);
            Console.WriteLine("Maior altura: " + maior); ;
            Console.WriteLine("Média das alturas das mulheres: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens: " + cont_m);

            Console.ReadLine();



        }
    }
}
