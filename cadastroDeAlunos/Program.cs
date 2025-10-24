string[] nomes = new string[3];
int[] idades = new int[3];
int totalaluno = 0;
int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("==== Aplicativo Sala de Aula ====");
    Console.WriteLine("1 - Listar Alunos");
    Console.WriteLine("2 - Cadastrar Aluno");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            ListarAlunos();
            break;

        case 2:
            CadastrarAlunos();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);

void ListarAlunos()
{
    Console.Clear();
    Console.WriteLine("== Listagem de Alunos ==");

    if (totalaluno == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado ainda!");
    }
    else
    {
        for (int t = 0; t < totalaluno; t++)
        {
            Console.WriteLine($"{t + 1} - Nome: {nomes[t]}, Idade: {idades[t]}");
        }
    }

    Console.WriteLine("\nDigite <Enter> para continuar...");
    Console.ReadLine();
}

void CadastrarAlunos()
{
    Console.Clear();
    Console.WriteLine("== Cadastro de Aluno ==");

    if (totalaluno >= nomes.Length)
    {
        Console.WriteLine("Limite de vagas atingido!");
        Console.WriteLine("Digite <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    Console.Write("Digite o nome do aluno: ");
    nomes[totalaluno] = Console.ReadLine();

    Console.Write("Digite a idade do aluno: ");
    idades[totalaluno] = int.Parse(Console.ReadLine());

    totalaluno++;

    Console.WriteLine("Aluno cadastrado com sucesso!");
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}
