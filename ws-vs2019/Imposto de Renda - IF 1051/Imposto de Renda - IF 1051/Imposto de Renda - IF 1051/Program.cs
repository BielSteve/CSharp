using System;
using System.Globalization;

namespace Imposto_de_Renda___IF_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto de Renda - IF 1051

            //declaração de variaveis
            double salario, imposto;

            Console.WriteLine("Digite o valor da sua renda para calcular o imposto: ");
            salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();

        }
    }
}
