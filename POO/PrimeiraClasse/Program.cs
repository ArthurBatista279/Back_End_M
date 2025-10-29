using System.Security.Authentication;
using PrimeiraClasse;

Carro mcLaren = new Carro();
mcLaren.marca = "Mclaren"
mcLaren.cor = "Vermelho"
mcLaren.modelo = "Senna"
mcLaren.potencia = "800cv"

Console.WriteLine($"Ligando a {mcLaren.marca} de {mcLaren.potencia}");

mcLaren.Ligar();

Console.WriteLine($"Acelarando a {mcLaren.marca} de {mcLaren.potencia} cv");

mcLaren.acelerar();

