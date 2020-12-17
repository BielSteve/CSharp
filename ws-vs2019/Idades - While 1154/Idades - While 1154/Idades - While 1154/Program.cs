using System;
using System.Globalization;

namespace Idades___While_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            //Idades - While 1154


            //Declaração de variaveis
            int idade, cont = 0;
            double media, soma = 0.0;

            Console.WriteLine("Digite sua idade otario: ");
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                cont++;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());

            }

            media = soma / cont;

            Console.WriteLine("A média das idades é : " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();





        }
    }
}
