string[] nomes = new string[5];
double[] saldos = new double[5];
int totalClientes = 0;
int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("==== Sistema Bancário Simples ====");
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
        case 0:
            Console.WriteLine("Encerrando o sistema...");
            break;

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

        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);

void CadastrarCliente()
{
    Console.Clear();
    Console.WriteLine("== Cadastro de Cliente ==");

    if (totalClientes >= nomes.Length)
    {
        Console.WriteLine("Limite de clientes atingido!");
    }
    else
    {
        Console.Write("Digite o nome do cliente: ");
        nomes[totalClientes] = Console.ReadLine();

        Console.Write("Digite o saldo inicial: ");
        saldos[totalClientes] = double.Parse(Console.ReadLine());

        totalClientes++;

        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void ListarClientes()
{
    Console.Clear();
    Console.WriteLine("== Lista de Clientes ==");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado ainda!");
    }
    else
    {
        for (int i = 0; i < totalClientes; i++)
        {
            Console.WriteLine($"{i + 1} - Nome: {nomes[i]}, Saldo: R$ {saldos[i]}");
        }
    }

    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void Depositar()
{
    Console.Clear();
    Console.WriteLine("== Depósito ==");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado!");
    }
    else
    {
        ListarClientes();

        Console.Write("Escolha o número do cliente: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice < 0 || indice >= totalClientes)
        {
            Console.WriteLine("Cliente inválido!");
        }
        else
        {
            Console.Write("Digite o valor do depósito: R$ ");
            double valor = double.Parse(Console.ReadLine());

            saldos[indice] += valor;

            Console.WriteLine("Depósito realizado com sucesso!");
        }
    }

    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void Sacar()
{
    Console.Clear();
    Console.WriteLine("== Saque ==");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado!");
    }
    else
    {
        ListarClientes();

        Console.Write("Escolha o número do cliente: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice < 0 || indice >= totalClientes)
        {
            Console.WriteLine("Cliente inválido!");
        }
        else
        {
            Console.Write("Digite o valor do saque: R$ ");
            double valor = double.Parse(Console.ReadLine());

            if (valor <= saldos[indice])
            {
                saldos[indice] -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }

    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void Transferir()
{
    Console.Clear();
    Console.WriteLine("== Transferência ==");

    if (totalClientes < 2)
    {
        Console.WriteLine("É necessário pelo menos 2 clientes cadastrados!");
    }
    else
    {
        ListarClientes();

        Console.Write("De quem vai enviar: ");
        int origem = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Para quem vai receber: ");
        int destino = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Digite o valor da transferência: R$ ");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= saldos[origem])
        {
            saldos[origem] -= valor;
            saldos[destino] += valor;
            Console.WriteLine("Transferência feita com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }

    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}
