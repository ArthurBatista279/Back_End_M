int quantidade;
double total;

Console.Write("Quantas maçãs foram compradas? ");
quantidade = int.Parse(Console.ReadLine());

if (quantidade < 12)
{
    total = quantidade * 0.30;
}
else
{
    total = quantidade * 0.25;
}

Console.WriteLine($"Valor total da compra: R$ {total:F2}");
