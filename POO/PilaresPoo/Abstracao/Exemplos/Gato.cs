namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"MIAU");
        }
        public override void Mover()
        {
            Console.WriteLine($"Sons de caminhada");
        }
    }
}