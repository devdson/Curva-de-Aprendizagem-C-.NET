using System;

namespace Aula07;

public class Program{

    
    
    public static void Main(){

        bool continuar = true;
        while (continuar) {
            Console.WriteLine("=====Calculadora Simples=====");

            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Selecionar o tipo de operação
            Console.WriteLine("\nEscolha uma operação: ");
            Console.WriteLine("1. Adição (+) ");
            Console.WriteLine("2. Subtração ");
            Console.WriteLine("3. Multiplicação ");
            Console.WriteLine("4. Divisão ");
            Console.WriteLine("Digite o número da operação: ");
            int operacao = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            // Condições
            if (operacao == 1) {

                result = num1 + num2;

            } 
            else if(operacao == 2){

                result = num1 - num2;
            }
            else if(operacao == 3){

                result = num1 * num2;
            }
            else if(operacao == 4) {

                result = num1 / num2;

            }

            Console.WriteLine(result);
            string resposta;

                do
                {
                    Console.WriteLine("Deseja realizar outra operação? (s/n)");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta != "s" && resposta != "n")
                    {
                        Console.WriteLine("Opção inválida. Digite apenas 's' ou 'n'.");
                    }

                } while (resposta != "s" && resposta != "n");

                if (resposta == "n")
                {
                    continuar = false;
                }
        }

    }
}