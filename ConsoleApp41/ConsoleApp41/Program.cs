using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Dígite o valor de X:");
            x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dígite o valor de Y:");
            y = int.Parse(Console.ReadLine());

            while(x!=y)
            {
                if(x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
                Console.WriteLine("Dígite o valor de X:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Dígite o valor de Y:");
                y = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
