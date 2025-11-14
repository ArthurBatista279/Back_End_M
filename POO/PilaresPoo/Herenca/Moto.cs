namespace Herenca
{
    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;

        public void Empinar()
        {
            Console.WriteLine($"{Marca} {Modelo} está empinando!");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Possui partida elétrica: {(TemPartidaEletrica ? "Sim" : "Não")}");
        }
    }
}
