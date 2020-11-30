using System;

namespace Tempo_de_Jogo___IF_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tempo de Jogo - IF 1046

            //Declarãção de variaveis
            int hora_inicio, hora_fim, duracao;

            Console.WriteLine("Digite a hora do inicio do jogo e do final: ");
            String[] vet = Console.ReadLine().Split(' ');
            hora_inicio = int.Parse(vet[0]);
            hora_fim = int.Parse(vet[1]);


            if (hora_inicio < hora_fim)
            {
                duracao = hora_fim - hora_inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else
            {
                duracao = 24 - hora_inicio + hora_fim;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            }

            Console.ReadLine();
        }
    }
}
