using System;

namespace Grenais___While_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grenais - While 1131
            //Biel Steve o mais brabo

            //Declaração de Variaveis
            int gol_Inter, gol_Gremio, cont_inter=0, cont_gremio=0, grenal, grenais=1, empate = 0;

            Console.WriteLine("Digite quantos gols: (Inter X Gremio):");
            String[] vet = Console.ReadLine().Split(' ');
            gol_Inter = int.Parse(vet[0]);
            gol_Gremio = int.Parse(vet[1]);

            if (gol_Inter > gol_Gremio)
            {
                cont_inter++;
            }
            else
            {
                cont_gremio++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            grenal = int.Parse(Console.ReadLine());
            while(grenal != 2)
            {
                grenais++;
                Console.WriteLine("Digite quantos gols: (Inter X Gremio):");
                vet = Console.ReadLine().Split(' ');
                gol_Inter = int.Parse(vet[0]);
                gol_Gremio = int.Parse(vet[1]);

                if (gol_Inter > gol_Gremio)
                {
                    cont_inter++;
                }
                else if (gol_Gremio > gol_Inter)
                {
                    cont_gremio++;
                }
                else
                {
                    empate++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenal = int.Parse(Console.ReadLine());
            }


            Console.WriteLine(grenais + " Grenais");
            Console.WriteLine("Inter venceu: " + cont_inter);
            Console.WriteLine("Gremio venceu: " + cont_gremio);
            Console.WriteLine("Empates: " + empate);
            if (cont_gremio > cont_inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Inter venceu mais");
            }

            Console.ReadLine();

        }
    }
}
