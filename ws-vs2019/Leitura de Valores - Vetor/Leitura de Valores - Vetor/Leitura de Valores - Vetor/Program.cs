using System;
using System.Globalization;


namespace Leitura_de_Valores___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de Valores - Vetor
            //Biel Steve


            //Declaração de variaveis
            int n;
            double[] vet;

            Console.WriteLine("Digite quantas posições tera o vetor: ");
            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Valores do vetor");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();


        }
    }
}
