using System;
using System.Globalization;

namespace Médias_Ponderadas___For_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            //Médias Ponderadas - For 1079
            //Biel Steve

            //Declaração de Variaveis
            int N;
            double x, y, z, media;

            Console.WriteLine("Digite quantas medias vc quer realizar : ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine("Digite os 3 valores para realizar a média: ");
                String[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                z = double.Parse(vet[2], CultureInfo.InvariantCulture);


                media = (x * 2 + y * 3 + z * 5) / (2 + 3 + 5);
                Console.WriteLine("Sua média otario: " + media.ToString("F1", CultureInfo.InvariantCulture));


            }
            Console.ReadLine();


        }
    }
}
