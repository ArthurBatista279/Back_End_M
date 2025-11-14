namespace Exemplos
{
    public class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            double taxa = valor * 0.03;
            double total = valor + taxa;

            if (total <= Saldo)
            {
                Saldo -= total;
                Console.WriteLine($"Saque: R${valor} | Taxa: R${taxa} | Saldo atual: R${Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}