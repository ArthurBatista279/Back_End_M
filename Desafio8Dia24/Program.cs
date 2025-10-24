int opcao;

do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1) Opção 1");
    Console.WriteLine("2) Opção 2");
    Console.WriteLine("3) Opção 3");
    Console.WriteLine("0) Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a Opção 1");
            break;
        case 2:
            Console.WriteLine("Você escolheu a Opção 2");
            break;
        case 3:
            Console.WriteLine("Você escolheu a Opção 3");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

} while (opcao != 0);
