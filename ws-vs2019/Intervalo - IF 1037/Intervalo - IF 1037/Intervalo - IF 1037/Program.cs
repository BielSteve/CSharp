using System;
using System.Globalization;

namespace Intervalo___IF_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intervalo - IF 1037

            //Declaração de variaveis
            double valor;
            string intervalo, resultado;

            Console.WriteLine("Digite o um valor: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (valor >= 0 && valor <= 25)
            {
                intervalo = "Intervalo [0,25]";
                Console.WriteLine("Intervalo" + intervalo);

            }
            else if (valor > 25 && valor <= 50)
            {
                intervalo = "Intervalo (25,50]";
                Console.WriteLine("Intervalo" + intervalo);

            }
            else if (valor > 50 && valor <= 75)
            {
                intervalo = "Intervalo (50,75]";
                Console.WriteLine("Intervalo" + intervalo);

            }
            else if (valor >= 75 && valor <= 100)
            {
                intervalo = "Intervalo (75,100]";
                Console.WriteLine("Intervalo" + intervalo);

            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.ReadLine();

        }
    }
}
