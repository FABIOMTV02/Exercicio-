using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, soma;
            Console.WriteLine("Calculo de Média: ");
            Console.WriteLine("Digite a 1° média: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2° média: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3° média: ");
            c = double.Parse(Console.ReadLine());

            soma = (a * 2 + b * 3 + c * 5) / 10;

            Console.WriteLine("A média é de: " + soma.ToString("F1"));

            Console.ReadLine();

        }
    }
}
