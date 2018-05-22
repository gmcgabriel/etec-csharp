//12. Elaborar um algoritmo que lê três valores a, b, c e os escreve. A seguir, encontre o maior dos três valores e o escreva com a mensagem; "É o maior”.

using System;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Informe um numero:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe outro numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Esse é maior: " + n1);


            }
            else
            {
                Console.WriteLine("Este é maior: " + n2);
            }
            Console.ReadKey();
        }
    }
}
