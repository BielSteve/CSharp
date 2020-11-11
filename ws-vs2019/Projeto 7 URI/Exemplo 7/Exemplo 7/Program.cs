using System;
using System.Globalization;

namespace Exemplo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis
            int numero, qtdaHorasTrabalhadas;
            double valorPorHora, salario;

            Console.WriteLine("Digite o numero do funcionario: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            qtdaHorasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor recebido por hora: ");
            valorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            salario = qtdaHorasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = " + "U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();        
        }
    }
}
