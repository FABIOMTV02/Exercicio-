using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("O valor é multíplo: ");
            }
            else
            {
                Console.WriteLine("O valor não é multíplo: ");
            }

            Console.ReadLine();
        }
    }
}
