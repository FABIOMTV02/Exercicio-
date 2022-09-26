using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Digite o valor: ");
            x = int.Parse(Console.ReadLine());

            for (y = 0; y <= (x*10); y ++)
            {
                y = y + 1;
                Console.WriteLine(y);
            }

            Console.ReadLine();
        }
    }
}
