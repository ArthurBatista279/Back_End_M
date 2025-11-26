using ClassesEstaticas;

float num1, num2;
int opcao;

do
{
    Console.Clear();
    Console.WriteLine("====== CALCULADORA ======\n");

    Console.Write("Digite o primeiro número: ");
    num1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    num2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    opcao = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcao)
    {
        case 1:
            CalculosMatematicos.Somar(num1, num2);
            break;

        case 2:
            CalculosMatematicos.Subtrair(num1, num2);
            break;

        case 3:
            CalculosMatematicos.Multiplicar(num1, num2);
            break;

        case 4:
            CalculosMatematicos.Dividir(num1, num2);
            break;

        case 0:
            Console.WriteLine("Programa encerrado.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (opcao != 0)
    {
        float maior = Math.Max(num1, num2);
        float menor = Math.Min(num1, num2);

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

} while (opcao != 0);
