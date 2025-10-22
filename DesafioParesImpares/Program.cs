int quantidade;
int numero;

Console.WriteLine("Quantos números você quer digitar?");
quantidade = int.Parse(Console.ReadLine());

string pares = "";
string impares = "";

for (int i = 1; i <= quantidade; i++)
{
    Console.Write($"Digite o {i} número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares = pares + numero + " ";
    }
    else
    {
        impares = impares + numero + " ";
    }
}

Console.WriteLine($"Números pares: {pares}");
Console.WriteLine($"Números ímpares: {impares}");
