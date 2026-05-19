using System;

public class Program{

    static void Main(){

        curso();

        int v1,v2;
        Console.WriteLine("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma(v1,v2);

    }

    static void curso(){

        Console.WriteLine("Curso");
    }

    static void soma(int v1, int v2){

        int resultado = v1 + v2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, resultado);
    }


}