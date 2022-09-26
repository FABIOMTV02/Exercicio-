using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            double resultado;

            Console.WriteLine("Dígite o valor de X1:");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dígite o valor de Y1:");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dígite o valor de X2:");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dígite o valor de X2:");
            y2 = double.Parse(Console.ReadLine());

            resultado = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            Console.WriteLine("O Valor da Distância é de: " + resultado.ToString("F4"));

            Console.ReadLine();
        }
    }
}
