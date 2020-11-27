using System;

namespace Menor_valor___IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menor valor - IF

            //declaração de variaveis
            int x, y, z;

            Console.WriteLine("Digite os valores de entrada: ");
            String[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x); 
            }
            else
            {
                if (y < x && y < z)
                {
                    Console.WriteLine("MENOR = " + y);
                }
                else
                {
                    Console.WriteLine("MENOR = " + z);
                }
            }

            Console.ReadLine();


        }
    }
}
