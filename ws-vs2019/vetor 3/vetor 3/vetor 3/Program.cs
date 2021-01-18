using System;

namespace vetor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor 3
            //Biel Steve
            int n;

            Console.WriteLine("Digite a quantidade de repetições : ");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];

            Console.WriteLine("Digite os valores: ");
            string[] valores = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(valores[i]);
            }

            Console.WriteLine("Digite os valores: ");
            valores = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(valores[i]);
            }


            int[] c = new int[n];

            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
            }

            Console.WriteLine("Vetor C tem esses valores: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(c[i] + " ");
            }

            Console.ReadLine();


        }
    }
}
