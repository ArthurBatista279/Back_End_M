int repeticoes;

Console.Write("Digite o número de repetições: ");
repeticoes = int.Parse(Console.ReadLine());

for (int i = 1; i <= repeticoes; i++)
{
    Console.WriteLine($"Repetição {i}:");

    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o seguindo número: ");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine($"O maior número é: {num1}");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"O maior número é: {num2}");
    }
    else
    {
        Console.WriteLine("Os dois números são iguais.");
    }
}
