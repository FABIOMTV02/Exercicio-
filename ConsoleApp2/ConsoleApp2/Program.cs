using System;

namespace ConsoleApp2
{
    internal class Program
    {
        string a;
        int b;
        double c;
        string[] vet;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string a = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Seu nome: " + a);
            Console.WriteLine("Sua idade: " + b);
            Console.WriteLine("Sua altura: " + c);
            Console.WriteLine();

            Console.WriteLine("Digite seu último nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            string idade = vet[1];
            string altura = vet[2];
            Console.WriteLine();

            Console.WriteLine("Seu último nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Sua altura é: " + altura);

            Console.ReadLine();
        }
    }
}
