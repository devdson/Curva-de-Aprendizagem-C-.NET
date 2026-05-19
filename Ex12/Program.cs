using System;

/* Projeto RPG

Faça um RPG de turno onde o usuário possa escolher entre quatro das classes de Herói: Guerreiro, Mago, Arqueiro e Assassino.

Cada herói possui as seguintes características: classe, vida e poder de ataque.

Ao escolher a classe que deseja jogar um vilão aleatório ira aparecer para enfrentar o herói.

Existem quatro vilões nesse jogo: Slime, Ladrão, Rei goblin e Aranha gigante. Cada vilão tem 
as seguintes características: nome, vida e poder de ataque.

Ao iniciar a batalha o herói poderá escolher se quer atacar ou usar uma esquiva.

Se decidir atacar o herói causará um dano no vilão, o dano causado será baseado no poder de ataque da classe escolhida. 
Logo em seguida o vilão ira atacar e causar um dano ao herói. o dano será baseado no poder de ataque de cada tipo de vilão.

Se decidir esquivar irá contar com a sorte.
Caso tenha sorte o herói conseguirá desviar por pouco mas causará um pequeno dano ao vilão durante a esquiva. 
O dano sofrido ao herói será metade do poder de ataque do vilão. O dano sofrido ao vilão será de 20% do poder de ataque do herói.

Caso não tenha sorte o herói não conseguirá esquivar e levará o dano por completo.
A batalha será realizada por turnos onde cada turno começa com a escolha de atacar ou esquivar e só termina
quando o herói conseguir derrotar o vilão ou ser derrotado pelo mesmo.
*/


using System;

public class Ex12
{
    public class Heroi
    {
        public string Classe;
        public int Vida;
        public int Ataque;

        public Heroi(string classe, int vida, int ataque)
        {
            Classe = classe;
            Vida = vida;
            Ataque = ataque;
        }
    }

    public class Vilao {

        public string Nome;
        public int Vida;
        public int Ataque;

        public Vilao(string nome, int vida, int ataque)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
        }
    }

    public static void Main(string[] args)
    {

    // Escolhendo a classe
        Console.WriteLine("----------NDS RPG----------");
        Console.WriteLine("Escolha sua classe: ");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");
        Console.WriteLine("4 - Assassino");

        int escolhendo = int.Parse(Console.ReadLine());

        Heroi jogador = null;

        switch (escolhendo)
        {
            case 1:
                jogador = new Heroi("Guerreiro", 100, 20);
                break;

            case 2:
                jogador = new Heroi("Mago", 75, 35);
                break;

            case 3:
                jogador = new Heroi("Arqueiro", 50, 25);
                break;

            case 4:
                jogador = new Heroi("Assassino", 65, 45);
                break;
        }

        Console.WriteLine("Classe escolhida: " + jogador.Classe);
        Console.WriteLine("Vida: " + jogador.Vida);
        Console.WriteLine("Poder de Ataque: " + jogador.Ataque);

    // Vilão sendo gerado
        Random random = new Random();

        int sorteio = random.Next('1, 5');

        Vilao inimigo = null;

        switch(sorteio)
        {
            case 1:
            inimigo = new Vilao("Slime", 55, 15);
            break;

            case 2:
            inimigo = new Vilao("Ladrão", 70, 25);
            break;

            case 3:
            inimigo = new Vilao("Rei goblin", 55, 35);
            break;

            case 4:
            inimigo = new Vilao("Aranha gigante", 100, 60);
        }


    }
}