using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            
            Console.WriteLine("Digite o valor de A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            C = double.Parse(Console.ReadLine());


            if (A == B || B == C || C == A)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else if (A == 8)
            {
                Console.WriteLine("2 Caso");
            }



            Console.ReadLine();
        }
    }
}
