using System;
using System.Globalization;

namespace Exemplo_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int X;
            double Y, medio;

            Console.WriteLine("Digite a distância percorrida em Km: ");
            X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de Conbustivel gasto: ");
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            medio = X / Y;

            Console.WriteLine("o consumo médio do automóvel é : " + medio.ToString("F3", CultureInfo.InvariantCulture)+ " km/l");

            Console.ReadLine();
        }
    }
}
