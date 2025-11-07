namespace Herenca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantas Portas: {QtdPortas}");
        }
    }
    

}