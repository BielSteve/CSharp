using System;
using System.Globalization;

namespace Vetor_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor 9
            //Biel Steve

            int n;

            Console.WriteLine("Digite quantos conjuntos deseja inserir: ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];

            Console.WriteLine("Digite os dados: ");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                compra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }

            int abaixo10 = 0, entre10e20 = 0, acima20 = 0;

            for (int i = 0; i < n; i++)
            {

                double lucro = venda[i] - compra[i];

                double porcentagemDeLucro = lucro / compra[i] * 100.0;

                if (porcentagemDeLucro < 10.0)
                {
                    abaixo10++;
                }
                else if (porcentagemDeLucro <= 20.0)
                {
                    entre10e20++;
                }
                else
                {
                    acima20++;
                }


            }
            Console.WriteLine("Lucro abaixo de 10%: " + abaixo10);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre10e20);
            Console.WriteLine("Lucro acima de 20%: " + acima20);

            // 2: vamos achar os totais
            double totalCompra = 0.0;
            double totalVenda = 0.0;
            for (int i = 0; i < n; i++)
            {
                totalCompra = totalCompra + compra[i];
                totalVenda = totalVenda + venda[i];
            }

            double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));

        }
        }
}
