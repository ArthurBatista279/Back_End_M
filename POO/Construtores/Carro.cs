namespace construtores
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string mar, string mod, int a)
        {

            Marca = mar;
            Modelo = mod;
            Ano = a;

        }

        public void Exibirdados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }
}