using System;

public class Pessoa
{
    public string Nome;
    public int Idade;
}

public class Aluno : Pessoa
{
    public string Curso;

    public void MostrarInfo()
    {
        Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Curso: {Curso}");
    }
}

public class Professor : Pessoa
{
    public string Disciplina;

    public void MostrarInfo()
    {
        Console.WriteLine($"Professor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
    }
}
