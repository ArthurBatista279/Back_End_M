namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;
        public int Idade;

        public override void FazerSom()
        {
            Console.WriteLine($"Ola, sou o {Nome}");
        }
        public override void Mover()
        {
            Console.WriteLine($"ZooPaaapapap");
        }
        public void Dormir()
        {
            Console.WriteLine($"Zzzzzzzzzz");
        }
    }
}