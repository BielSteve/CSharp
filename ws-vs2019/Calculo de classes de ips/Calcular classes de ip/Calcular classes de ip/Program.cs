using System;

namespace Calcular_classes_de_ip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculo de classes de Ips

 
            Console.WriteLine("Digite a sequencia do endereço de IP. Ex('100.10.1.20')");
            string[] vet = Console.ReadLine().Split(".");
            int oct1 = int.Parse(vet[0]);
            int oct2 = int.Parse(vet[1]);
            int oct3 = int.Parse(vet[2]);
            int oct4 = int.Parse(vet[3]);


            if (oct1 > 0 && oct1 < 128)
            {
                Console.WriteLine("A Classe é : A ");
                Console.WriteLine("REDE.HOST.HOST.HOST");
                Console.WriteLine("Endereço de rede é : " + oct1 + ".0.0.0");
                Console.WriteLine("Endereço de Broadcast é : " + oct1 + ".255.255.255");
                Console.WriteLine("A mascara é: 255.0.0.0");
                Console.WriteLine("A mascara também pode ser escrita: " + oct1 + ".0.0.0/8");
                Console.ReadLine();
            }
            if (oct1 >= 128 && oct1 < 192)
            {
                Console.WriteLine("A Classe é : B ");
                Console.WriteLine("REDE.REDE.HOST.HOST");
                Console.WriteLine("Endereço de rede é : " + oct1 +"."+ oct2 + ".0.0");
                Console.WriteLine("Endereço de Broadcast é : " + oct1 + oct2 + ".255.255");
                Console.WriteLine("A mascara é: 255.255.0.0");
                Console.WriteLine("A mascara também pode ser escrita: " + oct1 + "." + oct2 + ".0.0/16");
                Console.ReadLine();
            }
            if (oct1 >= 192 && oct1 < 224)
            {
                Console.WriteLine("A Classe é : C ");
                Console.WriteLine("REDE.REDE.REDE.HOST");
                Console.WriteLine("Endereço de rede é : " + oct1 + "." + oct2 + "." + oct3 + ".0");
                Console.WriteLine("Endereço de Broadcast é : " + oct1 + "." + oct2 + "." + oct3 + ".255");
                Console.WriteLine("A mascara é: 255.255.255.0");
                Console.WriteLine("A mascara também pode ser escrita: " + oct1 + "." + oct2 + "." + oct3 + ".0.0/24");
                Console.ReadLine();
            }
            if (oct1 >= 224 && oct1 < 255)
            {
                Console.WriteLine("A Classe é : D ");
                Console.WriteLine("Multicast");

            }
        }
    }
}
