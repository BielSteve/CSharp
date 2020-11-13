using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            //Criação de Vetor atraves do []
            Console.WriteLine("Entre com seu nome e sobrenome:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            string sobrenome = vet[1];

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdaQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Preço do produto?");
            double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu Sobrenome, idade e altura :");
            string[] v = Console.ReadLine().Split(' ');
            string sobrenome2 = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Os dados que você digitou foram:");
            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);
            Console.WriteLine(qtdaQuartos);
            Console.WriteLine(precoProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();






        }
    }
}
