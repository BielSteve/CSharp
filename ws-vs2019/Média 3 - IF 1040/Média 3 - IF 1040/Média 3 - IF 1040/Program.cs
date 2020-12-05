using System;
using System.Globalization;

namespace Média_3___IF_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            //Média 3 - IF 1040

            //declaração de variaveis

            float N1, N2, N3, N4, exame, media, media_final;

            Console.WriteLine("Digite as notas do alunos em sequencia : ");
            String[] vet = Console.ReadLine().Split(' ');
            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);
            

            media = (N1*2 + N2*3 + N3*4 + N4*1 ) / (2+3+4+1);

            if (media >= 7.0)
            {
                Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Reprovado");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame");

                Console.WriteLine("Digite a nota do exame: ");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                media_final = (media + exame) / 2;

                if (media_final >= 5.0)
                {
                    Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame");
                    Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno Aprovado!");
                    Console.WriteLine("Média Final: " + media_final.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if (media_final <= 4.9)
                {
                    Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame");
                    Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno Reprovado!");
                    Console.WriteLine("Média Final: " + media_final.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

           




            Console.ReadLine();
            
        }
    }
}
