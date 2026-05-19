using System;

namespace fibonacci;

public class Program{

    public static void Main(){

        // Faça um programa que gere a sequência de Fibonacci. O número de valores deve ser fornecido pelo usuário

        Console.WriteLine("Digite a quantidade de valores: ");
        int valores = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        Console.WriteLine(a);

        for (int i = 0; i < valores ; i++){

            int c = a + b;

            Console.WriteLine(c);

            a = b;
            b = c;

        }
    }
}