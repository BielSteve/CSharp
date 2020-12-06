using System;

namespace Tempo_de_Jogo_com_Minutos___IF_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Tempo de Jogo com Minutos - IF 1047
            
            //declaração de variaveis
            int hora_inicial, min_inicial, hora_final, min_final, instante_inicial, instante_final, duracao, duracao_horas, duracao_min;

            Console.WriteLine("Digite a hora inicial, min inicial, hora final e min final: ");
            String[] vet = Console.ReadLine().Split(' ');
            hora_inicial = int.Parse(vet[0]);
            min_inicial = int.Parse(vet[1]);
            hora_final = int.Parse(vet[2]);
            min_final = int.Parse(vet[3]);

            instante_inicial = hora_inicial * 60 + min_inicial;
            instante_final = hora_final * 60 + min_final;

            if (instante_inicial < instante_final)
            {
                duracao = instante_final - instante_inicial;
            }
            else
            {
                duracao = (24 * 60 - instante_inicial) + instante_final;
            }

            duracao_horas = duracao / 60;
            duracao_min = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracao_horas + " HORA(S) E " + duracao_min + " MINUTO(S)");

            Console.ReadLine();
        }
    }
}
