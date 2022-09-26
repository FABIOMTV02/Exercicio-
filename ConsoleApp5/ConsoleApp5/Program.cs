using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;
            Console.WriteLine("Entre com o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B: ");
            b = double.Parse(Console.ReadLine());
            s = a + b;
            Console.WriteLine("SOMA = " + s);

            Console.ReadLine();
        }
    }
}
