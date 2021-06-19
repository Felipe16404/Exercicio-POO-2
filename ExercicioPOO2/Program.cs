using System;

namespace VSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // classe Converter converte temperaturas para Celsius ou Fahrenheit
            Converter celsius = new Converter();
            double res1 = celsius.toFahrenheit(50);
            Console.WriteLine(res1);

            Converter fahrenheit = new Converter();
            double res2 = fahrenheit.toCelsius(50);
            Console.WriteLine(res2);

            // classe Matematica realiza operações simples de adição e multiplicação
            Matematica calculo1 = new Matematica();
            double resultado1 = calculo1.Adicao(5, 10);
            Console.WriteLine(resultado1);

            Matematica calculo2 = new Matematica();
            double resultado2 = calculo2.Multiplicacao(5, 10);
            Console.WriteLine(resultado2);

            // classe ImparPar diz se o numero inserido é impar ou par
            ImparPar n1 = new ImparPar(7);
            Console.WriteLine(n1.resultado);
        }
    }
}