using System;
using System.Globalization;


namespace Soma_e_Media___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma e Media - Vetor
            //Biel Steve

            //Declaração de Variaveis
            int n;
            //Criação de vetor
            double[] vet;

            Console.WriteLine("Digite quantas posições o vetor tera: ");
            n = int.Parse(Console.ReadLine());
            //instanciando vetor
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Resultados: ");
            // imprimindo resultados
            for (int i = 0; i < n; i++)
            {//Apenas Write para deixar na mesma linha
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];
            }

            double media = 0.0;

            media = soma / n;

            Console.WriteLine("Soma : " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media : " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
