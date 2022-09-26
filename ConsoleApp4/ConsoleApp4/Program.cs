using System;

namespace ConsoleApp4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double a, n, r;
            r = double.Parse(Console.ReadLine());
            n = 3.14159;
            r = Math.Pow(r, 2);
            a = r * n;
            Console.WriteLine("A=" + a);

        }
    }
}
