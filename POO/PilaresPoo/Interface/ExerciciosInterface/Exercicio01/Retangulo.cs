namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public double Largura;
        public double Altura;
        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}