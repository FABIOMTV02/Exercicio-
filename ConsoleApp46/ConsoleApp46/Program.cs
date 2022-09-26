using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, i;

            Console.WriteLine("Dígite o valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = 0; i <= (x - 1); i ++)
            {
                i = i + 1;
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
