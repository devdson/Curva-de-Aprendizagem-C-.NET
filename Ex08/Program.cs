using System;

namespace tabuleiro;

public class Program{

    // Crie um programa que imprima um tabuleiro nxm onde as paredes do tabuleiro serão representados por # e as casas por " “

    public static void Main(){

        Console.WriteLine("-----Tabuleiro-----");
        Console.WriteLine("Digite o número de linhas: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o número de colunas do tabuleiro: ");
        int colunas = int.Parse(Console.ReadLine());

        // Parte de cima
        for (int i = 0; i < linhas; i++) {

            Console.Write("#");
        }

        // Meio
        for (int i = 0; i < linhas; i++)
        {
            Console.Write("#");
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }

        // Parte de baixo
        for (int i = 0; i < linhas; i++) {

            Console.Write("#");
        }

    }
}