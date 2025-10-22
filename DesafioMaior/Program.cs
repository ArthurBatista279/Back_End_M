//Pedir para o usuario digitar dois numeros em seguida verificar qual é o maior dos dois numeros

// MAIOR NÚMERO
double num1, num2;

Console.WriteLine("\n=== Verificar o Maior Número ===");
Console.Write("Digite o primeiro número: ");
num1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
num2 = double.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"\nO maior número é: {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"\nO maior número é: {num2}");
}
else
{
    Console.WriteLine("\nOs dois números são iguais!");
}
