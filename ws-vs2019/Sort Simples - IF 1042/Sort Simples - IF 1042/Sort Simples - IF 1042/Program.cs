using System;

namespace Sort_Simples___IF_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort Simples - IF 1042
            //ordenado em ordem crescente

            //declaração de variaveis
            int valor1, valor2, valor3, a, b, c;

            Console.WriteLine("Digite 3 valores: ");
            String[] vet = Console.ReadLine().Split(' ');
            valor1 = int.Parse(vet[0]);
            valor2 = int.Parse(vet[1]);
            valor3 = int.Parse(vet[2]);

            if (valor1 > valor2 && valor1 > valor3)
            {
                c = valor1;

                if (valor2 > valor3)
                {
                    b = valor2;
                    a = valor3;
                }
                else
                {
                    b = valor3;
                    a = valor2;
                }
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                c = valor2;

                if (valor1 > valor3)
                {
                    b = valor1;
                    a = valor3;
                }
                else
                {
                    b = valor3;
                    a = valor1;
                }
            }
            else
            {
                c = valor3;

                if (valor2 > valor1)
                {
                    b = valor2;
                    a = valor1;
                }
                else
                {
                    b = valor1;
                    a = valor2;
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);

            Console.ReadLine();






        }
    }
}
