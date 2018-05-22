//Gabriel Miguel Camblor  - Não CONSEGUI
//Desenvolver um Cadastro de cliente com Vetor de 10 posições onde cada Cliente terá 08 campos; 
//  Nome, Endereço, Tel, Cidade, Bairro, UF, E-mail e CPF
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadclientewithvetor
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cad = new string[10];
            int i;
            Console.Write("Cadastro De Clientes v2.1  ");
            Console.WriteLine("\n\nDigite Seu Nome: "+cad[1]);
            cad[1] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSeu Endereco: " + cad[2]);
            cad[2] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSeu Telefone: " + cad[3]);
            cad[3] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSua Cidade: " + cad[4]);
            cad[4] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSeu Bairro: " + cad[5]);
            cad[5] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSeu UF: " + cad[6]);
            cad[6] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSeu EMail: " + cad[7]);
            cad[7] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nSeu cpf: " + cad[8]);
            cad[8] = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nSua conta foi cadastrada agora uma página aparecendo seus dados irá aparecer");
            Console.WriteLine("\nPressione uma tecla....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nNome cadastrado:"+cad[1]);
            Console.WriteLine("\nEndereço: "+cad[2]);
            Console.WriteLine("\nTelefone: " + cad[3]);
            Console.WriteLine("\nSua Cidade: " + cad[4]);
            Console.WriteLine("\nSeu Bairro: " + cad[5]);
            Console.WriteLine("\nSeu UF : " + cad[6]);
            Console.WriteLine("\nSua Email: " + cad[7]);
            Console.WriteLine("\nSeu cpf: " + cad[8]);




            Console.ReadKey();
        }
    }
}
