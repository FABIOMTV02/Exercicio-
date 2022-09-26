using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome1, nome2;
            double id1, id2, media;
            Console.WriteLine("Cálculo de Média:");
            Console.WriteLine("Digite o Nome e a Idade da 1° pessoa: ");
            nome1 = Console.ReadLine();
            id1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome e a Idade da 2° pessoa: ");
            nome2 = Console.ReadLine();
            id2 = double.Parse(Console.ReadLine());

            media = (id1 + id2) / 2;

            Console.WriteLine("A média de idade entre " + nome1 + " e " + nome2 + " é de: " + media);

            Console.ReadLine();
        }
    }
}
