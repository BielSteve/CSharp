using System;

namespace Crescente_e_Decrescente___While_1113
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crescente e Decrescente - While 1113

            //Declaração de variaveis
            int x, y;

            Console.WriteLine("Digite dois numeros inteiros : ");
            String[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);


            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");              
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }




            Console.ReadLine();

        }
    }
}
