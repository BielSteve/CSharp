using System;

namespace Idade_em_Dias___mod_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Idade em Dias - mod 1020

            //Declaração de variaveis
            int valor, anos, resto, meses, dias;

            Console.WriteLine("Digite o valor em dias para conversão: ");
            valor = int.Parse(Console.ReadLine());

            anos = valor / 365;
            resto = valor % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadLine();

        }
    }
}
