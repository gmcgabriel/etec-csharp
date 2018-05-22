using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, res;
            string var;

        ret:

            Console.WriteLine("Calculadora v1.0");
            Console.WriteLine("\nEscolha uma opção para cada tipo de calculo sendo: \n + para Soma \n - para Subtração \n * para Multiplicação \n / para Divisão");
            var = Convert.ToString(Console.ReadLine());


            switch (var)
            {
                case "*":
                    Console.Clear();
                    Console.WriteLine("Escolha o Primeiro Número para Multiplicarmos:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEscolha o Segundo Número para Multiplicarmos:");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    res = a1 * a2;
                    Console.WriteLine("\nA resposta para sua Multiplicação é " + res);
                    break;

                case "+":
                    Console.Clear();
                    Console.WriteLine("Escolha o Primeiro Número para Soma:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEscolha o Segundo Número para Soma:");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    res = a1 + a2;
                    Console.WriteLine("\nA resposta para sua Soma é " + res);
                    break;

                case "-":
                    Console.Clear();
                    Console.WriteLine("Escolha o Primeiro Número para Subtração:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEscolha o Segundo Número para Subtração:");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    res = a1 - a2;
                    Console.WriteLine("A sua resposta para sua Subtração é " + res);
                    break;

                case "/":
                    Console.Clear();
                    Console.WriteLine("Escolha o Primeiro Número para Divisão:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEscolha o Segundo Número para Divisão:");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    res = a1 / a2;
                    Console.WriteLine("A sua resposta para sua Divisão é " + res);

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Você digitou algo incorreto !!!");
                    Console.WriteLine("Pressione conforme Pedido !!!");
                    goto ret;
            }
            Console.Clear();
            Console.WriteLine("Pressione Uma Tecla Para Sair.");
            Console.ReadKey();


        }
    }
}

