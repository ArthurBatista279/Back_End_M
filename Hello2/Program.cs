string nome;
string sobrenome;
int idade;
float saldoconta;
double investimento;

Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Olá, qual é o seu sobrenome?");
sobrenome = Console.ReadLine();

Console.WriteLine("Olá, qual é sua Idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Olá, qual é o saldo Bancario?");
saldoconta = float.Parse(Console.ReadLine());

Console.WriteLine("Olá, qual são seus investimentos?");
investimento = float.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"nome: {nome} {sobrenome}");
Console.WriteLine($"idade do {nome} é {idade}");
Console.WriteLine($"saldoconta: {saldoconta}");
Console.WriteLine($"Investimento este ano: {investimento}");