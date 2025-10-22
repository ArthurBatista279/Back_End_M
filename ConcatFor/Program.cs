int letrasnonome;


Console.WriteLine("Olá, quantas letras tem o seu nome");
letrasnonome = int.Parse(Console.ReadLine());

string nome = "";

for (int t = 1; t <= letrasnonome; t++)
{
    Console.WriteLine($"Qual é a {t} letra");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome é {nome}");