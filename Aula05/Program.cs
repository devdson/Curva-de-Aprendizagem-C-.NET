namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----Par ou Ímpar-----");
        Console.WriteLine("Digite um número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if ( n % 2 == 0) {

            Console.WriteLine("O número é par");
        } else {

            Console.WriteLine("O número é ímpar.");
        }
    }
}