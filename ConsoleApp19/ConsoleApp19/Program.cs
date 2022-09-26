using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areatrianguloret, areacirculo, pi, areatrapezio, areaquadrado, arearetangulo;
            double a, b, c;

            Console.WriteLine("Digite o valor de (A)//(B)//(C): ");
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            pi = 3.14159;
            areatrianguloret = a * c / 2;
            areacirculo = pi * (c * c);
            areatrapezio = (a+b) * c / 2;
            areaquadrado = b * b;
            arearetangulo = a * b;

            Console.WriteLine("Área do triângulo retângulo: " + areatrianguloret.ToString("F3"));
            Console.WriteLine("Área do circulo: " + areacirculo.ToString("F3"));
            Console.WriteLine("Área do trapézio: " + areatrapezio.ToString("F3"));
            Console.WriteLine("Área do quadrado: " + areaquadrado.ToString("F3"));
            Console.WriteLine("Área do retângulo: " + arearetangulo.ToString("F3"));

            Console.ReadLine();

        }
    }
}
