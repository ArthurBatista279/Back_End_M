namespace Exemplos
{
    public class ContaCorrente : Conta
    {
        public override void Sacar(double valor)
        {
            double taxa = valor * 0.05; 
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
