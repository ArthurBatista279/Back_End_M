using Exercicio01;

Retangulo r = new Retangulo();
Console.Write("Digite a largura do retângulo: ");
r.Largura = double.Parse(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
r.Altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Área do retângulo: {r.CalcularArea()}");
Console.WriteLine();

Circulo c = new Circulo();
Console.Write("Digite o raio do círculo: ");
c.Raio = double.Parse(Console.ReadLine());

Console.WriteLine($"Área do círculo: {c.CalcularArea()}");
