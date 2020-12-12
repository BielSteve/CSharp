using System;

namespace Repetir_numeros_e_somar__While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repetir numeros e somar- While

            //declaração de variaveis
            int x, soma = 0;

            Console.WriteLine("Digite um valor inteiro : ");
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A soma dos numeros digitados é : " + soma);
            Console.ReadLine(); 
           
        }
    }
}
