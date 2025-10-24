double lado1, lado2, lado3;

Console.Write("Digite o primeiro lado: ");
lado1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo lado: ");
lado2 = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro lado: ");
lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}
