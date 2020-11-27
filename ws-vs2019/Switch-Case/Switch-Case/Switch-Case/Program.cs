using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch-Case
            //Declaração de variaveis
            int x;
            string dia;

            Console.WriteLine("Digite um numero para ver qual dia da semana represente: ");
            x = int.Parse(Console.ReadLine());

            //if (x == 1)
            //{
            //    dia = "domingo";
            //}
            //else if (x == 2)
            //{
            //    dia = "segunda";
            //}
            //else if (x == 3)
            //{
            //    dia = "terça";
            //}
            //else if (x == 4)
            //{
            //    dia = "quarta";
            //}
            //else if (x == 5)
            //{
            //    dia = "quinta";
            //}
            //else if (x == 6)
            //{
            //    dia = "sexta";
            //}
            //else if (x == 7)
            //{
            //    dia = "sabado";
            //}
            //else
            //{
            //    dia = "Valor invalido";
            //}
            
            switch (x)
            {
                case 1 :
                    dia = "domingo";
                    break;
                case 2 :
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "valor invalido";
                    break;
            }



            Console.WriteLine("dia da semana " + dia);

            Console.ReadLine();
        }
    }
}
