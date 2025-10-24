double salario, gastos;

Console.Write("Digite o salário recebido: ");
salario = double.Parse(Console.ReadLine());

Console.Write("Digite o total gasto: ");
gastos = double.Parse(Console.ReadLine());

if (gastos <= salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}
