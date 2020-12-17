using System;

namespace Tipo_de_Combustível___While_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de Combustível - While 1134

            //Declaração de variaveis
            int tipo, cont1=0, cont2=0, cont3=0;

            Console.WriteLine("Digite o tipo de combustivel : ");
            tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    cont1++;
                }
                else if (tipo == 2)
                {
                    cont2++;
                }
                else if (tipo == 3)
                {
                    cont3++;
                }
                else
                {
                    Console.WriteLine("Digite o codido de 1 - 4 apenas otario");
                }
                tipo = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool : " + cont1);
            Console.WriteLine("Gasolina : " + cont2);
            Console.WriteLine("Diesel : " + cont3);

            Console.ReadLine();





        }
    }
}
