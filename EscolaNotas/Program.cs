// MÉDIA DO ALUNO COM SITUAÇÃO
double n1, n2, n3, n4, media;

Console.WriteLine("Cálculo da Média do Aluno");
Console.Write("Digite a primeira nota: ");
n1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
n2 = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
n3 = double.Parse(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
n4 = double.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine($"\nMédia do aluno: {media:F1}");

if (media >= 7.0)
{
    Console.WriteLine("Situação: APROVADO");
}
else if (media >= 5.0 && media < 7.0)
{
    Console.WriteLine("Situação: RECUPERAÇÃO");
}
else
{
    Console.WriteLine("Situação: REPROVADO");
}
