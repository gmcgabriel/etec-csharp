//7. Uma empresa produz três tipos de peças mecânicas: parafusos, porcas e arruelas.Têm-se os preços unitários de cada tipo de peça e 
//sabe-se que sobre estes preços incidem descontos de 10% para porcas,
//  20% para parafusos e 30% para arruelas.Escreva um algoritmo que calcule o valor total da compra de um cliente. 
//   Deve ser mostrado o nome do cliente.O número de cada tipo de peça que o mesmo comprou, o total de desconto e o total a pagar pela compra.


using System;

namespace exercicio7edmodo
{
    class Program
    {

        static void Main(string[] args)
        {
            double par=0.33, dpar, dpor, por=4.98, darr, arr=4.90,total, ppor, parr, ppar;
            int npor, npar, narr;
            string client;

            Console.WriteLine("Bem Vindo Ao Sistemas De Cálculo De Peças ++ Descontos");

            Console.WriteLine("Digite o nome do Cliente:");
            client = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nDigite o número de Porcas Compradas:");
            npor = Convert.ToInt32(Console.ReadLine());
            ppor = npor * por;
            Console.WriteLine("\nDigite o número de Arruelas Compradas:");
            narr = Convert.ToInt32(Console.ReadLine());
            parr = narr * arr;
            Console.WriteLine("\nDigite o número de Parafusos Comprados:");
            npar = Convert.ToInt32(Console.ReadLine());
            ppar = npar * par;
            Console.Clear();
            Console.WriteLine("\nCliente: " + client);

            //Descontos 10% porcas, 20% par, 30% arr
            if (npor >= 1) {
                Console.WriteLine("\nPorca(s) Comprada(s)" + npor);
                dpor = (ppor * 10)/100;

            }
            else
            {
                dpor = 0;
                npor = 0;
                Console.WriteLine("\nPorca(s) Comprada(s):" + npor);
            }
            if (narr >= 1)
            {
                Console.WriteLine("\nArruela(s) Comprada(s): " + narr);
                darr = (parr * 30) / 100;
            }
            else
            {
                darr = 0;
                narr = 0;
                Console.WriteLine("\nArruela(s) Comprada(s): " + narr);
            }
            if (npar >= 1)
            {
                Console.WriteLine("\nParafuso(s) Comprado(s): " + npar);
                dpar = (ppar * 20) / 100;

            }
            else
            {
                Console.WriteLine("\nParafuso(s) Comprado(s): " + npar);
                dpar = 0;
                npar = 0;
            }



            // Não consegui colocar ele lá em cima porque teria que atribuir valor antes. Sei que fica "errado"
            double totald = dpar + darr + dpor;
            total = (ppar + ppor + parr) - totald;
            totald = dpor +darr+dpar;
            Console.WriteLine("\nTotal de desconto= R$ " + totald);
            Console.WriteLine("\nTotal a pagar = R$ " + total);
            Console.ReadKey();
        }
    }
}
