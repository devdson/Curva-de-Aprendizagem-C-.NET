using System;
using System.Collections.Generic;

namespace Aula17;

public class Program
{
    public static void Main()
    {
        // Instância da classe Bolo
        var morango = new Bolo();

        // Definir as informações do bolo de morango
        morango.Id = 296;
        morango.Name = "Bolo de morango";
        morango.Descricao = "Bolo não recomendado para diabéticos.";
        morango.Valor = 40;

        // Mostrar ao usuário
        Console.WriteLine("Código do produto: " + morango.Id);
        Console.WriteLine("Nome do produto: " + morango.Name);
        Console.WriteLine("Descrição: " + morango.Descricao);
        Console.WriteLine("Valor: R$ " + morango.Valor);

        // Novo bolo
        var chocolate = new Bolo();

        chocolate.Id = 127;
        chocolate.Name = "Bolo de chocolate";
        chocolate.Descricao = "Alto em cacau";
        chocolate.Valor = 50;

        // Lista de bolos
        Console.WriteLine("\nLista de Bolos");

        List<Bolo> cakeList = new List<Bolo>();
        cakeList.Add(morango);
        cakeList.Add(chocolate);

        foreach (Bolo bolo in cakeList)
        {
            Console.WriteLine("Código do produto: " + bolo.Id);
            Console.WriteLine("Nome do produto: " + bolo.Name);
            Console.WriteLine("Descrição: " + bolo.Descricao);
            Console.WriteLine("Valor: R$ " + bolo.Valor);
            Console.WriteLine("---------------------------");
        }
    }
}

