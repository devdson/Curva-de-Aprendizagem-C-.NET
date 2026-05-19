using System;

namespace maiormenor;

public class Program{

    public static void Main(){

        // Faça um programa que receba 3 valores e informe dentre eles qual é o maior e o menor.
        Console.WriteLine("-----Maior ou menor.-----");

        Console.WriteLine("Digite o primeiro número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        int maior = n1;
        int menor = n1;

        if (n2 > maior) maior = n2;
        if (n3 > maior) maior = n3;

        if (n2 < menor) menor = n2;
        if (n3 < menor) menor = n3;

        Console.WriteLine($"{maior} é o maior");
        Console.WriteLine($"{menor} é o menor");



    }
}