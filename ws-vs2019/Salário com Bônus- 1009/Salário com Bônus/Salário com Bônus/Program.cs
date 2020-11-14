using System;
using System.Globalization;

namespace Salário_com_Bônus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Salário com Bônus

            //declaração de variaveis
            string nome;
            double salario_fixo, vendas, total;

            Console.WriteLine("Nome do vendedor: ");
            nome = Console.ReadLine();
            Console.WriteLine("Salario : ");
            salario_fixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor total de vendas: ");
            vendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            total = vendas * 15.0 / 100 + salario_fixo;
            

            Console.WriteLine("O salario total de " + nome + " é de : " + "TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
