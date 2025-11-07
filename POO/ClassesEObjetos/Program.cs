/*
ContaBancaria conta = new ContaBancaria();

conta.titular = "Arthur";
conta.saldo = 100;

Console.WriteLine($"Bem-vindo, {conta.titular}!");
Console.WriteLine($"Seu saldo inicial é: R${conta.saldo}");

bool rodando = true;

while (rodando)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Ver saldo");
    Console.WriteLine("4 - Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite o valor do depósito: ");
            double dep = double.Parse(Console.ReadLine());
            conta.Depositar(dep);
            break;

        case "2":
            Console.Write("Digite o valor do saque: ");
            double saq = double.Parse(Console.ReadLine());
            conta.Sacar(saq);
            break;

        case "3":
            Console.WriteLine($"Saldo atual: R${conta.saldo}");
            break;

        case "4":
            rodando = false;
            Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
*/
Produto.produto = new Produto();
produto.nome = "Mouse Gamer";
produto.preco = 150.00;

produto.AplicarDesconto(10);
