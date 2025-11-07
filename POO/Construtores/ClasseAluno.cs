namespace Construtores
{
    public class ClasseAluno
    {
        public string nome;
        public double nota;

        public ClasseAluno()
        {
            nome = "Sem nome";
            nota = 0.0;
        }

        public ClasseAluno(string nome, double nota)
        {
            this.nome = nome;
            this.nota = nota;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {nome} | Nota: {nota}");
        }
    }
}