using System;

namespace Ex05;

public class Program{

    public static void Main(){

        //Crie um programa que receba duas notas e seus respectivos pesos e informe a media ponderada

        Console.WriteLine("-----Média Ponderada-----");

        Console.WriteLine("Digite o primeiro valor: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int m = ((n1 * 2) + (n2 * 3))/5;

        Console.WriteLine("A sua média é: " + m);

    }
}