using System;
using System.Globalization;

namespace Distância_Entre_Dois_Pontos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Distância Entre Dois Pontos

            //Declaração de variaveis
            double x1, x2, y1, y2, distancia;

            Console.WriteLine("Digite os valores de x1 e y1 : ");
            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os valores de x2 e y2 : ");
            string[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            //Calculo de raiz quadrada
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine("A distancia é : " + distancia.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
