using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.WriteLine("Dígite o valor: ");
            n = int.Parse(Console.ReadLine());

            for(i=1;i<=10;i++)
            {
                int resultado = i * n;
                Console.WriteLine(i + " x " + n + " = " + resultado);
            }


            Console.ReadLine();
        }
    }
}
