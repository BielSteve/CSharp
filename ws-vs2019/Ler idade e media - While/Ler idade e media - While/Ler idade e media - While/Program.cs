using System;
using System.Globalization;

namespace Ler_idade_e_media___While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler idade e media - While

            //Declaração de variaveis
            double idade, soma = 0.0, media;
            int cont = 0;

            Console.WriteLine("Digite as idades : ");
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine());

            }
            media = soma / cont;
            if (cont == 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else { 
            
                Console.WriteLine("A media das idades é : " + media.ToString("F2", CultureInfo.InvariantCulture));

            }

            Console.ReadLine();


        }
    }
}
