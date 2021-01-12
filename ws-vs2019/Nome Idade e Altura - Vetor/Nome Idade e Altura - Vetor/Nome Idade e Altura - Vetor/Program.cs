using System;
using System.Globalization;


namespace Nome_Idade_e_Altura___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nome Idade e Altura - Vetor
            //Biel Steve


            //Declaração de Variaveis
            int n;

            Console.WriteLine("Digite quantas repetições: ");
            n = int.Parse(Console.ReadLine());

            //Criação e instanciação de vetores
            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            // leitura dos dados
            Console.WriteLine("Digite o Nome, Idade e Altura na mesma linha");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //calculo da idade media
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //porcentagem das pessoas
            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            //double na frente do cont para evitar que os dados saim truncados
            double porcetagem = (double)cont / n * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos : " + 
                porcetagem.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();
        }
    }
}
