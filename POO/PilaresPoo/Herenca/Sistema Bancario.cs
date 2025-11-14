public class Conta
{
    public int Numero;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} realizado. Saldo atual: R${Saldo}");
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado. Saldo atual: R${Saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }
}

public class ContaPoupanca : Conta
{
    public void CalcularRendimento()
    {
        double rendimento = Saldo * 0.02;
        Saldo += rendimento;
        Console.WriteLine($"Rendimento de R${rendimento} aplicado. Novo saldo: R${Saldo}");
    }
}