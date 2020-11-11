using System;
using System.Globalization;

namespace Exemplo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis 
            int codigo, quantidade, quantidade2;
            double valor, valor2, valorFinal;

            Console.WriteLine("Digite o Codigo do Produto. A quantidade e em seguida o Valor:");
            //Criando array
            string[] v = Console.ReadLine().Split(' ');
            codigo = int.Parse(v[0]);
            quantidade = int.Parse(v[1]);
            valor = double.Parse(v[2], CultureInfo.InvariantCulture);

            
            Console.WriteLine("Digite o Codigo do Produto. A quantidade e em seguida o Valor:");
            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);


            valorFinal = quantidade * valor + quantidade2 * valor2;

            Console.WriteLine("VALOR A PAGAR =  R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();





        }
    }
}
