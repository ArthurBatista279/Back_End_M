int golsTime1, golsTime2;

Console.Write("Gols do primeiro time: ");
golsTime1 = int.Parse(Console.ReadLine());

Console.Write("Gols do segundo time: ");
golsTime2 = int.Parse(Console.ReadLine());

if (golsTime1 > golsTime2)
{
    Console.WriteLine("Vitória do primeiro time!");
}
else if (golsTime2 > golsTime1)
{
    Console.WriteLine("Vitória do segundo time!");
}
else
{
    Console.WriteLine("Empate!");
}
