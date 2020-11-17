using System;
using System.Globalization;

namespace Exemplo_1011_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1011 Esfera

            //Declaração de variaveis
            double r, v, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio : ");
            r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Fazendo calculo da raiz cubica
            v = (4 / 3.0) * pi * Math.Pow(r, 3.0);

            Console.WriteLine("O VOLUME É = " + v.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
