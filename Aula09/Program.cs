using System;

namespace Aula09;

public class Program{

    public static void Main(){

        // Switch Case
        Console.WriteLine("=====Desempenho Escolar=====");
        Console.WriteLine("Digite sua nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        switch (nota)
        {
            case 10:
            case 9:
                Console.WriteLine("Excelente");
                break;

            case 8:
            case 7:
                Console.WriteLine("Bom");
                break;
            
            case 6:
                Console.WriteLine("Regular");
                break;
            
            case 5:
                Console.WriteLine("Ruim");
                break;
            
            default:
                Console.WriteLine("Péssimo");
                break;
        }
    }
}