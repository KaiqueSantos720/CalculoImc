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

            if(imc < 17){
                Console.WriteLine("Classificação: Muito Abaixo do Peso");
            }

            else if(imc >= 17 && imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do Peso");
            }

            else if(18.5 <= imc && imc <= 24.9)
            {
                Console.WriteLine("Classificação: Peso Normal");
            }
            
            else if(25 <= imc && imc <= 29.9)
            {
                Console.WriteLine("Classificação: Acima do Peso");
            }

            else if(30 <= imc && imc <= 34.9)
            {
                Console.WriteLine("Classificação: Obesidade Grau I");
            }

            else if(35 <= imc && imc <= 39.9)
            {
                Console.WriteLine("Classificação: Obesidade Grau II");
            }

            else
            {
                Console.WriteLine("Classificação: Obesidade Mórbida");
            }

        }
    }
}
