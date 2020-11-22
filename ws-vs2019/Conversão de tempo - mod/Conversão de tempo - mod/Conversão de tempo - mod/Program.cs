using System;

namespace Conversão_de_tempo___mod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão de tempo - mod

            //Declaração de variaveis
            int N, horas, resto, minutos, segundos;

            Console.WriteLine("Digite o numero para conversão: ");
            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine("Resultado = " + horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();
        }
    }
}
