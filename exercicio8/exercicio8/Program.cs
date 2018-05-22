//8. A revendedora de carros Pica-Pau Ltda. paga aos seus funcionários vendedores dois salários mínimos fixos, mais uma comissão fixa de
//R$ 50,00 por carro vendido e mais 5% do valor das vendas. Faça um algoritmo que determine o salário total de um vendedor.

using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vendas;
            double salarioa, salarioaa, carro, salariom = 1908,mes;

            Console.WriteLine("\nQuantas Vendas Você Realizou");
            vendas = Convert.ToInt32(Console.ReadLine());
            carro = vendas * 50;
            Console.WriteLine("Digite o valor total de vendas do mês:");
            mes = Convert.ToInt32(Console.ReadLine());
            salarioa = (mes * 5) / 100;
            salarioaa = salarioa + salariom+carro;


            if (vendas >= 1)
            {
                Console.WriteLine("\nSeu Salário Total é igual á:  " + salarioaa);
            }
            else
            {
                Console.WriteLine("\nSeu Salário é igual ao normal  " + salariom);
            }
            Console.ReadKey();
        }
    }
}
