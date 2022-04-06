Console.WriteLine("Escreva seu nome");
string name = Console.ReadLine();

Console.WriteLine("Escreva sua massa");
double _massa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreva sua altura");
double _altura = Convert.ToDouble(Console.ReadLine());

Individuo i1 = new Individuo(name, _massa, _altura);
Console.WriteLine(i1.Imc);
i1.Classificacao();