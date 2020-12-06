using System;

namespace Animal___IF_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal - IF 1049

            //Declaração de variaveis
            string nome1, nome2, nome3;

            Console.WriteLine("Digite as 3 características:: ");
            nome1 = Console.ReadLine();
            nome2 = Console.ReadLine();
            nome3 = Console.ReadLine();

            //if vertebrado e invertebrado
            if (nome1 == "vertebrado" && nome2 == "ave" && nome3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (nome1 == "vertebrado" && nome2 == "ave" && nome3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (nome1 == "vertebrado" && nome2 == "mamifero" && nome3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (nome1 == "vertebrado" && nome2 == "mamifero" && nome3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            else if (nome1 == "invertebrado" && nome2 == "inseto" && nome3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (nome1 == "invertebrado" && nome2 == "inseto" && nome3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (nome1 == "invertebrado" && nome2 == "anelideo" && nome3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else
            {
                Console.WriteLine("minhoca");
            }




            Console.ReadLine();
        }
    }
}
