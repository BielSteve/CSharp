using System;
using System.Globalization;

namespace Area_de_um_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculando a area, perimetro e diagonal de um rentagulo

            //declaração de variaveis
            double b, a, area, perimetro, diagonal;

            Console.WriteLine("Digite o valor da base: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da altura: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * b + 2 * a;
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("A area é: " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O perimetro é: " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A diagonal é: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
