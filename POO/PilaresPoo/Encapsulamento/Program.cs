using Encapsulamento;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria ContaMaria = new ContaBancaria(1500);

contaEdu.Despositar(-100);
contaEdu.Despositar(20);
contaEdu.Sacar(-200);
ContaMaria.Sacar(300);

Console.WriteLine();

Console.WriteLine($"Saldo atual: R${contaEdu.GetSaldo()}");
Console.WriteLine($"Saldo atual: R${ContaMaria.GetSaldo()}");