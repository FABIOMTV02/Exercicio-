using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, dif;
            Console.WriteLine("Entre com o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de D: ");
            d = double.Parse(Console.ReadLine());

            dif = ((a * b) - (c * d));

            Console.WriteLine("A diferença é: " + dif);

            Console.ReadLine(); 


        }
    }
}
