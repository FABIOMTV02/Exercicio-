using System;

namespace ConsoleApp1
{
    internal class Program
    {
        string x;
        string[] v;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com uma palavra:");
            string x = Console.ReadLine();
            Console.WriteLine("Você disse a palavra: " + x);
            Console.WriteLine("Digite uma frase: ");
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            string d = v[3];
            string e = v[4];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}
