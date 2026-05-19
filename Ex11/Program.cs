using System;

/* 

Criar um tabuleiro de dimensão N fornecido pelo usuário (Mínimo 5), que contenha um jogador (P), um monstro (W) e 
um tesouro (G)

As paredes do tabuleiro serão demarcadas por (#) e as casas por (” “)

As posições do personagem, do monstro e do tesouro devem começar aleatoriamente no tabuleiro

O movimento do personagem deve ser apenas para esquerda, cima, direita e para baixo onde a cada movimento 
o monstro chega mais perto

O objetivo do jogo é fazer com que o personagem colete o tesouro antes que o monstro lhe ataque
Informe a pontuação total do jogador ao final de cada partida, ela começa com 1000 e decrementa 1 a cada movimento 
do personagem

*/

namespace wumpus;

public class Program {

    public static void Main(){

        Console.WriteLine("-----Wumpus Game-----");
        Console.WriteLine("Defina a dimensão do tabuleiro: ");
        int dimensao = int.Parse(Console.ReadLine());

        // Linha de cima
        for (int linhas = 0; linhas < dimensao ; linhas++){

            Console.Write("#");
        }

        Console.Write("\n");

        // Colunas 
        for (int linhas = 0; linhas < dimensao ; linhas++) {

            Console.Write("#");
            for ( int vazio = 0; vazio < (dimensao - 2) ; vazio++) {

                Console.Write(" ");
            }
            Console.WriteLine("#");
        }

        // Linha de baixo
        for (int linhas = 0; linhas < dimensao ; linhas++){

            Console.Write("#");
        }
 
    }
}