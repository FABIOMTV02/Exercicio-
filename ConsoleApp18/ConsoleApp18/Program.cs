using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, pi;
            Console.WriteLine("Cálculo do Volume de uma Esfera: ");
            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            pi = 3.14159;
            volume = (4/3.0) * pi * raio*raio*raio;

            Console.WriteLine("O volume é: " + volume.ToString("F2"));

            Console.ReadLine();
        }
    }
}
