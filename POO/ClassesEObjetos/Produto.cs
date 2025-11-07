namespace ClasseEObjeto
{
    public class Produto
    {
        public string nome = "";
        public double preco;

        public void AplicarDesconto(double percentual)
        {
            double desconto = preco * (percentual / 100);
            preco -= desconto;

            Console.WriteLine($"Desconto de {percentual}% aplicado!");
            Console.WriteLine($"Novo preço: R$ {preco:F2}");
        }
    }
}