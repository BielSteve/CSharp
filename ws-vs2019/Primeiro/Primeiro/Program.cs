using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;


            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");//Quebra de Linha Usando o "WriteLine"

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));//"F2" imprime com 2 casas
            Console.WriteLine(x.ToString("F4"));//"F4" imprime com 4 casa
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));//2 casas com o separador de pontos

            Console.ReadLine();
        
        }
    }
}
