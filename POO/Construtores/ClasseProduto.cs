
namespace Construtores
{
    public class ClasseProduto
    {
        public string nome;
        public double preco;
        public int estoque;

        public ClasseProduto(string nome, double preco, int estoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
            Console.WriteLine($"Estoque: {estoque} unidades");
        }

    }
}