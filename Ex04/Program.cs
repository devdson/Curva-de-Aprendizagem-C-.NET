using System;

namespace media;

public class Program{

    public static void Main(){

        // Média aritmética
        Console.WriteLine("-----Média Aritmética-----");

        Console.WriteLine("Digite o primeiro valor: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int m = (n1 + n2)/2;

        Console.WriteLine("A média é: " + m);
    }
}