using System;
using System.Globalization;

namespace Projeto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.WriteLine("Digite a largura:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Comprimento:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Preço do metro quadrado:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;
            Console.WriteLine("O resultado é:");
            Console.WriteLine("Area= " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco= " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
