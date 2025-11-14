namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"AU AU AU");
        }
        public override void Mover()
        {
            Console.WriteLine($"Sons de caminhada alto");
        }
    }
} 