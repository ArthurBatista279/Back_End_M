using Construtores;

{
    
    {
        ClasseProduto produto1 = new ClasseProduto("Mouse Gamer", 150.00, 20);

        Console.WriteLine("=== Dados do Produto ===");
        produto1.MostrarDados();
    }
}
    
/*
Carro Pagani = new Carro("Pagani", "Utopia", 2025 );

Pagani.Exibirdados();
*/

/*
{
    {
        ClasseAluno aluno1 = new ClasseAluno();

        ClasseAluno aluno2 = new ClasseAluno("Arthur", 9.5);

        Console.WriteLine("=== Dados dos Alunos ===");
        aluno1.MostrarDados();
        aluno2.MostrarDados();
    }
}
*/

/* Pessoa.cs 
Console.Clear();
Pessoa michele = new Pessoa();
Pessoa joao = new Pessoa("Joao Costa", 43);

michele.Nome = "Michele Alves";
michele.Idade = 25;

joao.ExibirDados();
michele.ExibirDados();

Pessoa milena = new Pessoa("Milena", 17, "Gosto de Morango");
*/