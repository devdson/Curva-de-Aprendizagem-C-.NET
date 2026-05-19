using System;

namespace Ex06;

public class Program{

    public static void Main(){

    // Faça um programa que solicite do usuário uma operação entre 
    // soma, divisão, multiplicação e subtração, receba dois numero e mostre o resultado da operação.

    Console.WriteLine("-----Calculadora Simples-----");

    while(true) {

        Console.WriteLine("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma operação de 1 a 4: \n 1)Soma \n 2)Subtração \n 3)Multiplicação \n 4)Divisão ");
        int operacao = Convert.ToInt32(Console.ReadLine());

        switch (operacao) {

            case 1:
                Console.WriteLine("O resultado é: " + (n1 + n2));
                break;

            case 2:
                Console.WriteLine("O resultado é: " + (n1 - n2));
                break;
            
            case 3:
                Console.WriteLine("O resultado é: " + (n1 * n2));
                break;
            
            case 4:
                Console.WriteLine("O resultado é: " + (n1 / n2));
                break;
            
            default:
                Console.WriteLine("Digite uma opção válida. ");
                continue;

        }

        }
    }
}