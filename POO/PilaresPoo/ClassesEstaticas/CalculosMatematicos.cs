namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        public static void Somar(float x, float y)
        {
            Console.WriteLine($"Soma: {x + y}");
        }

        public static void Subtrair(float x, float y)
        {
            Console.WriteLine($"Subtração: {x - y}");
        }

        public static void Multiplicar(float x, float y)
        {
            Console.WriteLine($"Multiplicação: {x * y}");
        }

        public static void Dividir(float x, float y)
        {
            if (y == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"Divisão: {x / y}");
            }
        }
    }
}
