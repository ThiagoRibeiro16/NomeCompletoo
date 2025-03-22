Console.Clear();

string nome;
string sobrenome;

Console.Write($"{"digite seu nome".PadRight(20, '.')}: ");
nome = Console.ReadLine()!;

Console.Write($"{"digite seu sobrenome".PadRight(20, '.')}: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"seu nome é: {nome} {sobrenome}");

Console.Write($"seu nome catálogo é: {sobrenome.ToUpper()}, {nome}");