using System;
using System.Globalization;

namespace Operadores_Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadaores de Atribuição Cumulativa
            //Declaração de variaveis
            int minutos;
            double conta;

            Console.WriteLine("digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                //conta = conta + (minutos - 100) * 2.0; é a mesma coisa
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar = " + conta.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

            // a += b; é a mesma coisa a = a + b;
            // a -= b; é a mesma coisa a = a - b;
            // a *= b; é a mesma coisa a = a * b;
            // a /= b; é a mesma coisa a = a / b;
            // a %= b; é a mesma coisa a = a % b;


        }
    }
}
