using System;

/* Crie um programa que crie uma Struct usuário com os atributos: 
    Name,  LastName, Idade e Altura. E em seguida imprima os valores */
struct Usuario
{
    public string Name;
    public string LastName;
    public int Idade;
    public double Altura;
}

class Program
{
    static void Main()
    {
        Usuario usuario;

        usuario.Name = "João";
        usuario.LastName = "Silva";
        usuario.Idade = 25;
        usuario.Altura = 1.75;

        Console.WriteLine("Nome: " + usuario.Name);
        Console.WriteLine("Sobrenome: " + usuario.LastName);
        Console.WriteLine("Idade: " + usuario.Idade);
        Console.WriteLine("Altura: " + usuario.Altura + "m");
    }
}