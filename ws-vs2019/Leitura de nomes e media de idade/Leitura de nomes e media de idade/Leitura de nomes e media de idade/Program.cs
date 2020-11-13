using System;
using System.Globalization;

namespace Leitura_de_nomes_e_media_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura de nomes e media de idade

            //Declaração de variaveis
            double media;

            //criação de vetor
            Console.WriteLine("Digite o nome1 e a idade1 na mesma linha(EX: Maria 20): ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            int idade1 = int.Parse(vet[1]);

            //criação de vetor
            Console.WriteLine("Digite o nome2 e a idade2 na mesma linha(EX: Maria 20): ");
            string[] v = Console.ReadLine().Split(' ');
            string nome2 = v[0];
            int idade2 = int.Parse(v[1]);


            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de : " + media.ToString("F1" , CultureInfo.InvariantCulture) + " anos");
            Console.ReadLine();
        }
    }
}
