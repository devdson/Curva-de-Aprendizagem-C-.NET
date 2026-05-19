Console.Write("Quantos números deseja informar? ");
int quantidade = int.Parse(Console.ReadLine());

int maior = 0;
int menor = 0;

for (int i = 1; i <= quantidade; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());

    // Primeira repetição define os valores iniciais
    if (i == 1)
    {
        maior = numero;
        menor = numero;
    }
    else
    {
        if (numero > maior)
            maior = numero;

        if (numero < menor)
            menor = numero;
    }
}

Console.WriteLine($"Maior valor: {maior}");
Console.WriteLine($"Menor valor: {menor}");