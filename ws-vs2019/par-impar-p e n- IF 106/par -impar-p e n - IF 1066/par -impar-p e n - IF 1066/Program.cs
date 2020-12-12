using System;

namespace par__impar_p_e_n___IF_1066
{
    class Program
    {
        static void Main(string[] args)
        {



                //Declaração de variaveis
                int v1, v2, v3, v4, v5, p = 0, n = 0, par = 0, impar = 0;

                Console.WriteLine("Digite 5 valores : ");
                v1 = int.Parse(Console.ReadLine());
                v2 = int.Parse(Console.ReadLine());
                v3 = int.Parse(Console.ReadLine());
                v4 = int.Parse(Console.ReadLine());
                v5 = int.Parse(Console.ReadLine());


                //descobrindo positivos e negativos
                if (v1 > 0)
                {
                    p = p + 1;
                }
                else if(v1 < 0)
                {
                    n = n + 1;
                }
                if (v2 > 0)
                {
                    p = p + 1;
                }
                else if (v2 < 0)

                {
                n = n + 1;
                }
                if (v3 > 0)
                {
                    p = p + 1;
                }
                else if (v3< 0)

                {
                n = n + 1;
                }
                if (v4 > 0)
                {
                    p = p + 1;
                }
                else if (v4 < 0)
    
                {
                n = n + 1;
                }
                if (v5 > 0)
                {
                    p = p + 1;
                }
                else if (v5 < 0)
                {
                    n = n + 1;
                }

                //descobrindo par ou impar
                if (v1 % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
                if (v2 % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
                if (v3 % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
                if (v4 % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
                if (v5 % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }

                Console.WriteLine(par + " valor(es) par(es)");
                Console.WriteLine(impar + " valor(es) impar(es)");
                Console.WriteLine(p + " valor(es) positivo(s)");
                Console.WriteLine(n + " valor(es) negativo(s)");

                Console.ReadLine();

            }
        }
}
