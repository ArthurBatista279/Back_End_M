

namespace ClassesEObjetos
{
    public class ContaBancaria
    {
        public string titular = "";
        public double saldo = 0;

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado. Saldo atual: R${saldo}");
        }

        public void Sacar(double valor)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado. Saldo atual: R${saldo}");
        }
    }
}