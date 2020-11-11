using System;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1

            //Declaração de Variaveis 
            int x, y;
            double b, B, h, area;
            //Calculando a area de um trapezio
            b = 6.0;
            B = 8.0;
            h = 5.0;


            x = 5;

            y = 2 * x;


            area = (b + B) / 2.0 * h;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(area);



            Console.ReadLine();
        }
    }
}
