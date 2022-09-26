using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salariobase, vendas, total;
            
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sálario base: ");
            salariobase = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de suas vendas: ");
            vendas = double.Parse(Console.ReadLine());

            total = (vendas * 0.15) + salariobase;

            Console.WriteLine("O vendedor " + nome + " vai receber: " + total.ToString("F1"));

            Console.ReadLine();
        }
    }
}
