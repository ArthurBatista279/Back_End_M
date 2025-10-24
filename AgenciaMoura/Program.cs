string[] nomes = new string[5];
double[] saldos = new double[5];
int totalClientes = 0;
int opcao = -1;

while (opcao != 0)
{
    Console.Clear();
    Console.WriteLine("Sistema Bancário Simples");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Transferir");
    Console.WriteLine("5 - Listar Clientes");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        case 0:
            Console.WriteLine("Encerrando o sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}

void CadastrarCliente()
{
    Console.Clear();
    Console.WriteLine("Cadastro de Cliente");

    if (totalClientes >= nomes.Length)
    {
        Console.WriteLine("Limite de clientes atingido!");
        return;
    }

    Console.Write("Digite o nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();

    Console.Write("Digite o saldo inicial: ");
    saldos[totalClientes] = double.Parse(Console.ReadLine());

    totalClientes++;

    Console.WriteLine("Cliente cadastrado com sucesso!");
}

void ListarClientes()
{
    Console.Clear();
    Console.WriteLine("Lista de Clientes");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado!");
        return;
    }

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i + 1} - {nomes[i]} | Saldo: R$ {saldos[i]:F2}");
    }
}

void Depositar()
{
    Console.Clear();
    Console.WriteLine("Depósito");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado!");
        return;
    }

    ListarClientes();
    Console.Write("Escolha o número do cliente para depósito: ");
    int indice = int.Parse(Console.ReadLine()) - 1;

    if (indice < 0 || indice >= totalClientes)
    {
        Console.WriteLine("Cliente inválido!");
        return;
    }

    Console.Write("Digite o valor do depósito: R$ ");
    double valor = double.Parse(Console.ReadLine());

    if (valor <= 0)
    {
        Console.WriteLine("Valor inválido!");
        return;
    }

    saldos[indice] += valor;

    Console.WriteLine($"Depósito realizado com sucesso! Novo saldo de {nomes[indice]}: R$ {saldos[indice]:F2}");
}

void Sacar()
{
    Console.Clear();
    Console.WriteLine("Saque");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado!");
        return;
    }

    ListarClientes();
    Console.Write("Escolha o número do cliente para saque: ");
    int indice = int.Parse(Console.ReadLine()) - 1;

    if (indice < 0 || indice >= totalClientes)
    {
        Console.WriteLine("Cliente inválido!");
        return;
    }

    Console.Write("Digite o valor do saque: R$ ");
    double valor = double.Parse(Console.ReadLine());

    if (valor <= 0)
    {
        Console.WriteLine("Valor inválido!");
        return;
    }

    if (valor > saldos[indice])
    {
        Console.WriteLine("Saldo insuficiente!");
        return;
    }

    saldos[indice] -= valor;

    Console.WriteLine($"Saque realizado com sucesso! Novo saldo de {nomes[indice]}: R$ {saldos[indice]:F2}");
}

void Transferir()
{
    Console.Clear();
    Console.WriteLine("Transferência");

    if (totalClientes < 2)
    {
        Console.WriteLine("É necessário pelo menos 2 clientes cadastrados!");
        return;
    }

    ListarClientes();
    Console.Write("Escolha o número do cliente que vai enviar: ");
    int origem = int.Parse(Console.ReadLine()) - 1;

    Console.Write("Escolha o número do cliente que vai receber: ");
    int destino = int.Parse(Console.ReadLine()) - 1;

    if (origem < 0 || origem >= totalClientes || destino < 0 || destino >= totalClientes)
    {
        Console.WriteLine("Cliente inválido!");
        return;
    }

    if (origem == destino)
    {
        Console.WriteLine("Não é possível transferir para o mesmo cliente!");
        return;
    }

    Console.Write("Digite o valor da transferência: R$ ");
    double valor = double.Parse(Console.ReadLine());

    if (valor <= 0)
    {
        Console.WriteLine("Valor inválido!");
        return;
    }

    if (valor > saldos[origem])
    {
        Console.WriteLine("Saldo insuficiente para transferência!");
        return;
    }

    saldos[origem] -= valor;
    saldos[destino] += valor;

    Console.WriteLine($"Transferência de R$ {valor:F2} realizada de {nomes[origem]} para {nomes[destino]} com sucesso!");
}
