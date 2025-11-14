namespace Exemplos
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado. Saldo atual: R${Saldo}");
        }

        public abstract void Sacar(double valor); // obrigatório nas filhas
    }
}
