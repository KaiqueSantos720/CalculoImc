public class Individuo
{
    public string Nome {get; set;}
    public double Massa {get; set;}
    public double Altura {get; set;}
    public Individuo (string nome, double massa, double altura)
    {
        Nome = nome;
        Massa = massa;
        Altura = altura;
    }
    public double Imc { get => (Massa/(Altura * Altura));}

    public void Classificacao()
    {
        if(Imc < 17){
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Muito Abaixo do Peso");
            Console.WriteLine("Você precisa ganhar {0} kg", (18.5*(Altura*Altura))-Massa);
        }

        else if(Imc >= 17 && Imc < 18.5)
        {
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Abaixo do Peso");
            Console.WriteLine("Você precisa ganhar {0} kg", (18.5*(Altura*Altura))-Massa);
        }

        else if(18.5 <= Imc && Imc <= 24.9)
        {
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Peso Normal");
        }
            
        else if(25 <= Imc && Imc <= 29.9)
        {
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Acima do Peso");
            Console.WriteLine("Você precisa perder {0} kg", Massa-(24.9*(Altura*Altura)));
        }

        else if(30 <= Imc && Imc <= 34.9)
        {
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Obesidade Grau I");
            Console.WriteLine("Você precisa perder {0} kg", Massa-(24.9*(Altura*Altura)));
        }

        else if(35 <= Imc && Imc <= 39.9)
        {
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Obesidade Grau II");
            Console.WriteLine("Você precisa perder {0} kg", Massa-(24.9*(Altura*Altura)));
        }

        else
        {
            Console.WriteLine("IMC: {0}", Imc);
            Console.WriteLine("Classificação: Obesidade Mórbida");
            Console.WriteLine("Você precisa perder {0} kg", Massa-(24.9*(Altura*Altura)));
        }
    }
}