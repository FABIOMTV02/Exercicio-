using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("Digite a distância entre os dois veículos: ");
            Console.WriteLine();
            valor = double.Parse(Console.ReadLine());
            valor = valor * 2;
            Console.WriteLine();
            Console.WriteLine("O tempo para alcançar o outro veículo é de " + valor + " minutos. ");


            Console.ReadLine();
        }
    }
}
