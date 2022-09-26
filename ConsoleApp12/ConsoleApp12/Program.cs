using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, soma;
            Console.WriteLine("Calculo de Notas: ");
            Console.WriteLine();
            Console.WriteLine("Digite a 1° nota: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2° nota: ");
            b = double.Parse(Console.ReadLine());

            soma = ((a * 3.5) + (b * 7.5) / 11);

            Console.WriteLine("SOMA = " + soma.ToString("F1"));

            Console.ReadLine();
        }
    }
}
