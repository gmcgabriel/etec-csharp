//9. Um hotel cobra R$ 60.00 a diária e mais uma taxa de serviços.A taxa de serviços é de: • R$ 5.50 por diária, se o número de diárias for maior que 15; 
//• R$ 6.00 por diária, se o número de diárias for igual a 15; • R$ 8.00 por diária,
//    se o número de diárias for menor que 15. Construa um algoritmo que mostre o nome e o total da conta de um cliente.

// 5,50 diaria, porém diaria>15=6,00    diaria=15 diaria=8  60+taxa

using System;

namespace exerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente;
            double diaria = 60, taxa, total, totald, tempo, taxad;

            volta:
            Console.Clear();
            Console.WriteLine("Cálculo Total HOTEL");
            Console.WriteLine("\nDigite O Nome Do Cliente");
            cliente = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite quantos dias ele está no hotel: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            if (tempo< 15 && tempo>0)
            {
                totald = tempo * diaria;
                taxa=5.50;
                taxad = taxa * tempo;
                total = taxad + totald;
                Console.WriteLine("O Valor total a pagar do cliente  " + cliente + "é : "+total);

            }else if (tempo > 15)
            {
                totald = tempo * diaria;
                taxa = 6.00;
                taxad = taxa * tempo;
                total = taxad + totald;
                Console.WriteLine("O Valor total a pagar do cliente  " + cliente + "é : " + total);

            }
            else if (tempo == 15)
            {
                totald = tempo * diaria;
                taxa = 8.00;
                taxad = taxa * tempo;
                total = taxad + totald;
                Console.WriteLine("O Valor total a pagar do cliente  " + cliente + " é : " + total);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Algo não está certo, pressione uma tecla e tente novamente");
                Console.ReadKey();
                goto volta;

            }
            Console.ReadKey();
        }
    }
}
