using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();

int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("Olá, bem vindo ao sistema!");
    Console.WriteLine("1 - Cadastrar Fatura");
    Console.WriteLine("2 - Cadastrar Relatório");
    Console.WriteLine("3 - Cadastrar Contrato");
    Console.WriteLine("4 - Listar Faturas");
    Console.WriteLine("5 - Listar Relatórios");
    Console.WriteLine("6 - Listar Contratos");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            CadastrarFaturas();
            break;

        case 2:
            CadastrarRelatorios();
            break;

        case 3:
            CadastrarContratos();
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            ListarRelatorios();
            break;

        case 6:
            ListarContratos();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

} while (opcao != 0);


void CadastrarFaturas()
{
    Console.WriteLine("Cadastrar Fatura");
    Console.Write("Nome do Cliente Devedor: ");
    string dev = Console.ReadLine();

    Console.Write("Nome da empresa: ");
    string empresa = Console.ReadLine();

    Console.Write("Valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());

    Console.Write("Dias de atraso: ");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);

    Console.WriteLine("Fatura cadastrada com sucesso!");
}

void CadastrarRelatorios()
{
    Console.WriteLine("Cadastrar Relatório");
    Console.Write("Título do relatório: ");
    string titulo = Console.ReadLine();

    Console.Write("Autor do relatório: ");
    string autor = Console.ReadLine();

    Relatorio r = new Relatorio(titulo, autor);
    documentos.Add(r);

    Console.WriteLine("Relatório cadastrado com sucesso!");
}

void CadastrarContratos()
{
    Console.WriteLine("Cadastrar Contrato");

    Console.Write("Nome do contratante: ");
    string nome = Console.ReadLine();

    Console.Write("Serviço contratado: ");
    string servico = Console.ReadLine();

    Contrato c = new Contrato(nome, servico);
    documentos.Add(c);

    Console.WriteLine("Contrato cadastrado com sucesso!");
}

void ListarFaturas()
{
    Console.WriteLine("=== LISTA DE FATURAS ===");

    foreach (var item in documentos)
    {
        if (item is Fatura)
            item.Imprimir();
    }
}

void ListarRelatorios()
{
    Console.WriteLine("=== LISTA DE RELATÓRIOS ===");

    foreach (var item in documentos)
    {
        if (item is Relatorio)
            item.Imprimir();
    }
}

void ListarContratos()
{
    Console.WriteLine("=== LISTA DE CONTRATOS ===");

    foreach (var item in documentos)
    {
        if (item is Contrato)
            item.Imprimir();
    }
}
