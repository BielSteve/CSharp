using System;
using System.Globalization;


namespace Maior_Numero___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maior Numero - Vetor
            //Biel Steve

            int n, posicao = 0;
            double maior = 0.0;


            Console.WriteLine("Digite a quantidade de repetições : ");
            n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];

            Console.WriteLine("Digite os numeros: ");
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i + 1;
                }
            }


            Console.WriteLine("Maior numero : " + maior.ToString("F1", CultureInfo.InvariantCulture) + " ");
            Console.Write("Posição: " + posicao);

            Console.ReadLine();


        }
    }
}
