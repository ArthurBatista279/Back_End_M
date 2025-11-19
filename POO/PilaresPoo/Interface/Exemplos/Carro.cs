namespace Exemplos
{
    public class Carro : IMotor
    {

        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = m;
            Ano = a;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Informações do Veiculo:

            Marca: {Marca}
            Ano: {Ano}
            Modelo: {Modelo}
            Cor: {Cor}");
        }

        public void Acelerar()

        {
            Console.WriteLine($"Carroo acelerando... Frum Frum");
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro Freiando... irrrrrrr");
        }
    }
}