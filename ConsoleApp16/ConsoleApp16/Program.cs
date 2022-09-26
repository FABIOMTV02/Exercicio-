using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double idade1, idade2, soma;
            string[] vet;

            Console.WriteLine("Cálculo de Média: ");
            Console.WriteLine("Digite o nome da 1° pessoa: ");
            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = double.Parse(vet[1]);
            Console.WriteLine("Digite o nome da 2° pessoa: ");
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = double.Parse(vet[1]);

            soma = (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + soma + " anos.");

            Console.ReadLine();
        }
    }
}
