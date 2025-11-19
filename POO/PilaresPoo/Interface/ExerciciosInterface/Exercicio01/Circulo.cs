using System.Text.RegularExpressions;

namespace Exercicio01
{
    public class Circulo
    {
        public double Raio;
        public double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}