using System;

namespace Ex07;

public class Program{

/* 
Crie um programa que receba o nome completo de uma pessoa ex:

Eduardo Janta 
* remova todos os espaços laterais
* remova todos os espaço excedentes entre os nomes
* passe todas as letras para minusculo
* passe todas as letras para maiúsculo
* adicione uma nova palavra ao nome
* remova uma palavra do nome
* pesquise uma palavra dentro do nome
* informe a quantidade de letras no nome
*/
    public static void Main()
    {
        Console.WriteLine("Digite um nome próprio: ");
        string nome = Console.ReadLine();

        // Remova todos os espaços laterais
        nome = nome.Trim();

        // Passe todas as letras para minúsculo
        nome = nome.ToLower();

        // Passe todas as letras para maiúsculo
        nome = nome.ToUpper();

        // Adicione uma palavra ao nome
        string palavra = "Tchau";
        string resultado = nome + " " + palavra;  // Adiciona "Tchau" com espaço no meio

        // Pesquise uma palavra dentro do nome
        string palavra2 = "João";
        
        if (nome.Contains(palavra2))
        {
            Console.WriteLine("Palavra encontrada");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada.");
        }

        // Informe a quantidade de letras no nome
        int quantidadeLetras = nome.Length;
        Console.WriteLine("A quantidade de letras no nome é: " + quantidadeLetras);

        // Exibe o resultado final
        Console.WriteLine("Resultado final: " + resultado);
    }
}