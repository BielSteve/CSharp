using System;
using System.Globalization;
namespace Area_de_tudo_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area de tudo 1012

            //declaração de variaveis

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            Console.WriteLine("Digite os 3 valores para calcular as areas. (Ex: 3.0 2.0 1.0)");

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1],CultureInfo.InvariantCulture);
            C = double.Parse(vet[2],CultureInfo.InvariantCulture);


            //area triangulo
            triangulo = A * C / 2;
            //area circulo
            circulo = pi * Math.Pow(C, 2.0);
            //areaa trapezio
            trapezio = (C * (A + B)) / 2;
            //area quadrado
            quadrado = B * B;
            //area  retangulo
            retangulo = A * B;

            Console.WriteLine("Area do TRIANGULO É = " + triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Area do CIRCULO É = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do TRAPEZIO É = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do QUADRADO É = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do RETANGULO É = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();




        }
    }
}
