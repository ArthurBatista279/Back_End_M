double media, frequencia;

Console.Write("Digite a média do aluno: ");
media = double.Parse(Console.ReadLine());

Console.Write("Digite a frequência (%): ");
frequencia = double.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Situação: REPROVADO por frequência");
}
else if (media >= 7)
{
    Console.WriteLine("Situação: APROVADO");
}
else if (media >= 3)
{
    Console.WriteLine("Situação: RECUPERAÇÃO");
}
else
{
    Console.WriteLine("Situação: REPROVADO por média");
}
