using System;
using System.Globalization;

namespace Aumento_de_Salário___IF_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aumento de Salário - IF 1048

            //declaração de variaveis
            double salario, novo_salario, reajuste, percentual;

            Console.WriteLine("Digite o salario para consultar o reajuste: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if ( salario <= 400.00)
            {
                percentual = 15;
                reajuste = (salario * 0.15);
                novo_salario = salario + reajuste;
                Console.WriteLine("Novo Salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + "%");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = (salario * 0.12);
                novo_salario = salario + reajuste;
                Console.WriteLine("Novo Salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + "%");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = (salario * 0.10);
                novo_salario = salario + reajuste;
                Console.WriteLine("Novo Salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + "%");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = (salario * 0.07);
                novo_salario = salario + reajuste;
                Console.WriteLine("Novo Salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + "%");
            }
            else if (salario > 2000.00)
            {
                percentual = 4;
                reajuste = (salario * 0.04);
                novo_salario = salario + reajuste;
                Console.WriteLine("Novo Salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + "%");
            }


            Console.ReadLine();

        }
    }
}
