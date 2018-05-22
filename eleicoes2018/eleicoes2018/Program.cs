// Exercicio 1 Programação Aluno: Gabriel Miguel Camblor Turma: MSI 2° Módulo RM 706. Exercicio referente ao dia 06/04/18
//1)Considere que a eleição eleitoral de 2018 apresente estas condições abaixo:

//Idade < 16 condições ” Você não pode votar”.

//Idade >= 16 condições < 18 ” Voto Optativo ”.

//Idade > = 18 condições < 65 ” Voto Obrigatório ”.

//Idade > = 65 condições ” Voto Optativo”.


using System;

namespace eleicoes2018
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarando Variaveis e Convertendo.
            int idade;
            Console.WriteLine("Verifique a partir da sua idade sua obrigatoriedade ou não de voto !!!\n ");
            Console.WriteLine("Digite Sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            // Desenvolvendo o programa utilizando comando if,else if.
            if (idade < 16) {
                Console.WriteLine("Você não pode votar");

            }else if (idade >= 16 && idade < 18){
                Console.WriteLine("Voto Optativo");
                    }else if (idade >= 18 && idade < 65){
                        Console.WriteLine("Voto Obrigatório");
                        }else if (idade >= 65){
                            Console.WriteLine("Voto Optativo");
                            }else {
                                Console.WriteLine("Você digitou um valor inválido");
            }

            //Finalização (Escrevendo encerramento do programa + comando para pressionar tecla para encerrá-lo)
            Console.WriteLine("\nFim do Programa, Pressione uma tecla para sair...");
            Console.ReadKey();
        }
          

            }

        }
