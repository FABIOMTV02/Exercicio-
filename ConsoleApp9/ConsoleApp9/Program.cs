using System;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dist, quant, result;
            Console.WriteLine("Informe a distância percorrida: ");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe a quantidade de combustível consumido: ");
            quant = double.Parse(Console.ReadLine());

            result = dist / quant;

            Console.WriteLine("O consumo aproximado de combustível é de: " + result.ToString("F1"));

            Console.ReadLine();
        }
    }
}
