using System;

namespace Aula19;

public class Program{

    public static void Main(){

        // Criar instância da classe Person
        Person person = new Person();

        // Métodos
        Console.WriteLine("Digite uma idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        bool ifMaioridade = person.Maioridade(idade);

        if (ifMaioridade == true){

            Console.WriteLine("Maior de idade");
        } else {

            Console.WriteLine("Menor de idade");
        }
    }
}