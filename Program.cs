Console.WriteLine("Escreva seu nome");
string? _name = Console.ReadLine();

Console.WriteLine("Escreva sua massa");
double _massa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreva sua altura");
double _altura = Convert.ToDouble(Console.ReadLine());

Individuo i1 = new Individuo(_name, _massa, _altura);
Console.WriteLine(i1.VerImc);
Console.WriteLine(i1.Classificacao());
Console.WriteLine(i1.PesoIdeal());