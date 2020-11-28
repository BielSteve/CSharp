using System;

namespace Teste_de_Seleção_1___IF_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste de Seleção 1 - IF 1035

            //Declaração de variaveis
            int A, B, C, D, soma1, soma2;

            Console.WriteLine("Digite 4 valores na mesma linha: ");
            String[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            soma1 = C + D;
            soma2 = A + B;
            //A % 2 == 0 vai descobrir se o resto da divisão por 2 é igual a 0

            if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && A % 2 == 0){
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");

            }

            Console.ReadLine();


        }
    }
}
