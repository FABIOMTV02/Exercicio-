using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempo, velocidade, km,  gasto;
            Console.WriteLine("Digite a quantidade de tempo: ");
            tempo = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a velocidade constante: ");
            velocidade = double.Parse(Console.ReadLine());
            Console.WriteLine();

            km = velocidade * tempo;
            gasto = km / 12;

            Console.WriteLine("A viajem teve um trajeto de " + km + " km");
            Console.WriteLine("E a quantidade de combústivel gasto foi de " + gasto + " litros.");

            Console.ReadLine();
        }
    }
}
