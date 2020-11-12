using System;
using System.Globalization;

namespace Exemplo_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;
            double  litros, distancia;

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade media: ");
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros = distancia / 12.0;

            Console.WriteLine("A quantidade de litros necessarios para essa viagem são : " + litros.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
            
        }
    }
}
