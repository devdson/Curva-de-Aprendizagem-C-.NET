namespace Aula04 {

    public class Program {

        public static void Main(){

            // Operadores Aritiméticos

            Console.WriteLine("-----Cálculadora Simples-----");

            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            int sub = n1 - n2;
            int produto = n1 * n2;
            int div = n1 / n2;


            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + sub);
            Console.WriteLine("O valor do produto é: " + produto);
            Console.WriteLine("O valor da divisão é: " + div);
        }
    }
}