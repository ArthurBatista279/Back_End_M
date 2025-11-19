namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Titulo;
        public string Autor;

        public Relatorio(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public void Imprimir()
        {
            Console.WriteLine($"[Relatório] {Titulo} (Autor: {Autor})");
        }
    }


}