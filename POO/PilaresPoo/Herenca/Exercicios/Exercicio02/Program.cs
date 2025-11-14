Funcionario f1 = new Funcionario();
f1.Nome = "Arthur";
f1.SalarioBase = 2500;

Gerente g1 = new Gerente();
g1.Nome = "Maria";
g1.SalarioBase = 2500;
g1.Bonus = 1000;

Console.WriteLine($"{f1.Nome} - Salário: R${f1.CalcularSalario()}");
Console.WriteLine($"{f1.Nome} - Salário: R${f1.CalcularSalario()}");