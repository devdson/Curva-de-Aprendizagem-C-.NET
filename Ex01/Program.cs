using System;

namespace parimpar;

public class Program {

    public static void Main(){

        // Crie um programa que receba um número do usuário e informe se ele é par ou impar
        Console.WriteLine("-----Par ou Ímpar-----");
        Console.WriteLine("Digite um número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if ( n % 2 == 0) {

            Console.WriteLine("O número é par.");
        } else {

            Console.WriteLine("O número é ímpar.");
        }


    }
}