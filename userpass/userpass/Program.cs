using System;

namespace userpass
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = 123, cont=1;
            string user;

            Console.WriteLine("Sistema De Login V1.0");
            Console.WriteLine("\n Digite seu nome de usuário:");
            user = Convert.ToString(Console.ReadLine());
            Console.Clear();
        volta:
            Console.WriteLine("\n Digite sua senha:");
            pass = Convert.ToInt32(Console.ReadLine());

            if (pass == 123)
            {
                Console.WriteLine("Bem Vindo Ao Sistema");
            }
            else
            {
                while(pass != 123 && cont<=2)
                {
                    Console.WriteLine("Senha Inválida !!!");
                    cont++;
                    Console.Clear();
                    goto volta;
                }
            }
            Console.WriteLine("Senha Inválida pelo limite de 3 vezes");
            Console.ReadKey();
        }


    }
}
