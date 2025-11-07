using Calculadora;

Calculator Calc = new Calculator();

Calc.Num1 = 50;

Calc.Num2 = 10;

int opcao = -1;

do
{
    Console.WriteLine("== Calculadora ==");
    Console.WriteLine("== Bem vindo a calculadora, escolha uma das opções ==");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Diminuir");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Subtrair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            Console.WriteLine($"Primeiro Número: {Calc.Num1}");
            Console.WriteLine($"Segundo Número: {Calc.Num2}");
            Console.WriteLine();    

            Console.WriteLine($"Resultado: {Calc.Somar()}");
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine($"Primeiro Número: {Calc.Num1}");
            Console.WriteLine($"Segundo Número: {Calc.Num2}");
            Console.WriteLine();

            Console.WriteLine($"Resultado: {Calc.Subtrair()}");
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine($"Primeiro Número: {Calc.Num1}");
            Console.WriteLine($"Segundo Número: {Calc.Num2}");
            Console.WriteLine();

            Console.WriteLine($"Resultado: {Calc.Multiplicar()}");
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine($"Primeiro Número: {Calc.Num1}");
            Console.WriteLine($"Segundo Número: {Calc.Num2}");
            Console.WriteLine();

            Console.WriteLine($"Resultado: {Calc.Subtrair()}");
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("opção invalida");
            Console.WriteLine("Clique <Enter> para continuar..");
            Console.ReadLine();
            break;


    }
} while (opcao != 0);