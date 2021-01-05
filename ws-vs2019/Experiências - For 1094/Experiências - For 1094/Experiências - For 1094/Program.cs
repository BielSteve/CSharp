using System;
using System.Globalization;

namespace Experiências___For_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            //Experiências - For 1094
            //Biel Steve

            //Declaração de variaveis
            int N, x, total = 0, C = 0, R = 0, S = 0;
            char tipo;
            double perc_C, perc_R, perc_S;


            Console.WriteLine("Quantos casos de testes vem a seguir: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite a quantidade e o tipo de Cobaia('C/R/S')");
                String[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                //quantidade de cada especie
                if (tipo == 'C')
                {
                    C = C + x;
                }
                else if (tipo == 'R')
                {
                    R = R + x;
                }
                else if (tipo == 'S')
                {
                    S = S + x;
                }
                else
                {
                    Console.WriteLine("ERRO OTARIO"); 
                }

                //total de cobaias
                total = total + x;

            }
            //percentual de cada especie
            perc_C = (double)C / total * 100.0;
            perc_R = (double)R / total * 100.0;
            perc_S = (double)S / total * 100.0;

            Console.WriteLine("Total : " + total + " Cobaias");
            Console.WriteLine("Total de coelhos: " + C);
            Console.WriteLine("Total de ratos: " + R);
            Console.WriteLine("Total de sapos: " + S);
            Console.WriteLine("Percentual de coelhos : " + perc_C.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos : " + perc_R.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos : " + perc_S.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();




        }
    }
}
