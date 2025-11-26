namespace ClassesEstáticas_Encapsulamento
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual;

        public void DefinirMarca(string Valor)
        {
            Marca = Valor;
        }
        public string ObterMarca()
        {
            return Marca;
        }
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
        public string ObterModelo()
        {
            return Modelo;
        }
        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }
        public void Acelerar(int valor)
        {
            VelocidadeAtual += valor;
        }
        public void Frear(int valor)
        {
            VelocidadeAtual -= valor;
        
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
    }   
}