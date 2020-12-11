using System;

namespace DDD___IF_1050
{
    class Program
    {
        static void Main(string[] args)
        {
            //DDD if 1050

            //declaração de variaveis
            int x;
            string cidade;

            Console.WriteLine("Digite o DDD: ");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 61:
                    cidade = "Brasilia";
                    break;
                case 71:
                    cidade = "Salvador";
                    break;
                case 11:
                    cidade = "São Paulo";
                    break;
                case 21:
                    cidade = "Rio de Janeiro";
                    break;
                case 32:
                    cidade = "Juiz de Fora";
                    break;
                case 19:
                    cidade = "Campinas";
                    break;
                case 27:
                    cidade = "Vitoria";
                    break;
                case 31:
                    cidade = "Belo Horizonte";
                    break;
                default:
                    cidade = "DDD não Cadastrado";
                    break;
            }

            Console.WriteLine(cidade);

            Console.ReadLine();


        }
    }
}
