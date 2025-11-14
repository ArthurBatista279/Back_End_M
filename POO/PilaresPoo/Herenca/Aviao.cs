namespace Herenca
{
    public class Aviao : Veiculo
    {
        public double Envergadura;

        public void Decolar()
        {
            Console.WriteLine($"{Marca} {Modelo} está decolando!");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Envergadura: {Envergadura} metros");
        }
    }
}
