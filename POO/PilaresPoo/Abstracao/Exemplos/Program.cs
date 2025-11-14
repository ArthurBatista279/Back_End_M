/*
Gato Lipinho = new Gato();
Cachorro DUQUE = new Cachorro();
Pessoa Clovis = new Pessoa();

Clovis.Nome = "Clovis";
Clovis.Idade = 18;

Console.Clear();

Clovis.FazerSom();
Clovis.Mover();
Clovis.Dormir();
*/

using Exemplos;

Conta conta;

Console.WriteLine("Escolha o tipo de conta:");
Console.WriteLine("1 - Corrente");
Console.WriteLine("2 - Poupança");
int tipo = int.Parse(Console.ReadLine());

if (tipo == 1)
    conta = new ContaCorrente();
else
    conta = new ContaPoupanca();

conta.Numero = 123;


bool rodando = true;

while (rodando)
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Ver Saldo");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    int opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.Write("Valor do depósito: ");
            double d = double.Parse(Console.ReadLine());
            conta.Depositar(d);
            break;

        case 2:
            Console.Write("Valor do saque: ");
            double s = double.Parse(Console.ReadLine());
            conta.Sacar(s);
            break;

        case 3:
            Console.WriteLine($"Saldo atual: R${conta.Saldo}");
            break;

        case 0:
            rodando = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
