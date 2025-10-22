//Producao - 6.5
//Administrativo - 7.5
//Diretoria - 12

//salario = salario * 1.0065
//salario = salario * 1.0075
//salario = salario * 1.0012

//De acordo com a tabela acima faça um programa que receba o cargo e o salario de um funcionario e calcule e imprima o salario reajustado


double salario;
string cargo;

Console.WriteLine("Cálculo do Salário Reajustado");
Console.Write("Digite o cargo (Producao, Administrativo ou Diretoria): ");
cargo = Console.ReadLine();

Console.Write("Digite o salário atual: ");
salario = double.Parse(Console.ReadLine());

if (cargo == "Producao")
{
    salario = salario * 1.0065;
}
else if (cargo == "Administrativo")
{
    salario = salario * 1.0075;
}
else if (cargo == "Diretoria")
{
    salario = salario * 1.12;
}
else
{
    Console.WriteLine("Cargo inválido!");
    return;
}

Console.WriteLine($"\nCargo: {cargo}");
Console.WriteLine($"Salário reajustado: R$ {salario:F2}");
