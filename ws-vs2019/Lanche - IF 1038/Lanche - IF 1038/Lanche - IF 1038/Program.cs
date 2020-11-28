using System;
using System.Globalization;

namespace Lanche___IF_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lanche - IF 1038

            //Declaração de variaveis
            int cod, qtda;
            double total;

            Console.WriteLine("Digite o codigo e a quantidade na mesma linha: ");
            String[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qtda = int.Parse(vet[1]);

            switch (cod)
            {
                case 1:
                    total = 4.00 * qtda;
                    break;
                case 2:
                    total = 4.50 * qtda;
                    break;
                case 3:
                    total = 5.00 * qtda;
                    break;
                case 4:
                    total = 2.00 * qtda;
                    break;
                case 5:
                    total = 1.50 * qtda;
                    break;
                default:
                    total = 0;
                    break;

            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
