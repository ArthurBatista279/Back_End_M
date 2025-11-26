namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }
        public void Despositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor inválido");
            }
            else
            {
                Saldo += valor;
            }

        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)

        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo!");
            }
        }
    }
}
