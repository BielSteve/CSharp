using System;
using System.Globalization;

namespace Nota_Escolar___If
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nota Escolar - If

            //Declaração de Variaveis
            double nota1, nota2, soma;

            Console.WriteLine("Digite a nota 1 :");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 2 :");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1"),CultureInfo.InvariantCulture);

            if (soma < 60)
            {
                Console.WriteLine("REPROVADO OTARIO!");
            }

            Console.ReadLine();

        }
    }
}
