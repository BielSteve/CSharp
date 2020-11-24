using System;

namespace If__Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis

            int horas;

            Console.WriteLine("Que horas são ?");
            horas = int.Parse(Console.ReadLine());


            if (horas <= 12)
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("Boa Tarde");
                }
                else
                {
                    Console.WriteLine("Boa noite"); 
                }
            }




            Console.ReadLine();


        }
    }
}
