using System;

namespace Senha_Fixa___While_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            //Senha Fixa - While 1114

            //Declaração de Variaveis
            int senha;

            Console.WriteLine("Digite a senha otario: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido otario");

            Console.ReadLine();




        }
    }
}
