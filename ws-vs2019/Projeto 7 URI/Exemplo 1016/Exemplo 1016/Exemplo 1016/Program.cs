using System;

namespace Exemplo_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;

            Console.WriteLine("Digite a distancia : ");
            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2;

            Console.WriteLine("Vai levar :" + tempo + " minutos");

            Console.ReadLine();


        }
    }
}
