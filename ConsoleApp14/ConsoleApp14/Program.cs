using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, b, area, perimetro, diagonal;
            Console.WriteLine("Cálculo da área/perímetro e diagonal de um retângulo");
            Console.WriteLine("Digite o valor da Base: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura: ");
            altura = double.Parse(Console.ReadLine());

            area = b * altura;
            perimetro = 2 * b + 2 * altura;
            diagonal = Math.Sqrt(b * b + altura * altura);

            Console.WriteLine("À área é: " + area.ToString("F2"));
            Console.WriteLine("O perímetro é: " + perimetro.ToString("F2"));
            Console.WriteLine("A diagonal é: " + diagonal.ToString("F2"));

            Console.ReadLine();
        }
    }
}
