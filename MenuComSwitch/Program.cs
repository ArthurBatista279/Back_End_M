int opcao;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("          Bem Vindo, Usuário");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

Console.WriteLine("Escolha uma opção do menu abaixo:");
Console.WriteLine("1) Hot Holl");
Console.WriteLine("2) Temaki");
Console.WriteLine("3) Sashimi");
Console.WriteLine("4) Yakisoba");
Console.WriteLine("5) Guioza");
Console.WriteLine("6) Shimeji");
Console.WriteLine("0) Sair");

Console.Write("Digite sua opção: ");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu Hot Holl");
        break;
    case 2:
        Console.WriteLine("Você escolheu Temaki");
        break;
    case 3:
        Console.WriteLine("Você escolheu Sashimi");
        break;
    case 4:
        Console.WriteLine("Você escolheu Yakisoba");
        break;
    case 5:
        Console.WriteLine("Você escolheu Guioza");
        break;
    case 6:
        Console.WriteLine("Você escolheu Shimeji");
        break;
    case 0:
        Console.WriteLine("Saindo do menu...");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}
