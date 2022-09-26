using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Dígite o valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Dígite o valor de Y: ");
            y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Ponto de Origem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }


            Console.ReadLine();
        }
    }
}
