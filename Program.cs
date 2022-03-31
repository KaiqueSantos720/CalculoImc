using System;

namespace CalculoImc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu nome: ");
            string? nome = Console.ReadLine();

            Console.WriteLine("Escreva a sua massa em kilogramas: ");
            float massa = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva o sua altura em metros: ");
            float altura = Convert.ToSingle(Console.ReadLine());

            double imc = massa/(altura*altura);

            Console.WriteLine("Olá {0} seu IMC é: {1}", nome, imc);

        }
    }
}
