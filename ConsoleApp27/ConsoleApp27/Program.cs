using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double delta, a, b, c, r1, r2;

            Console.WriteLine("Cálculo de Fórmula de Bhaskara");
            Console.WriteLine("Digite o valor A // B // C: ");
            
            string[] vetor = Console.ReadLine().Split(' ');                     

            a = double.Parse(vetor[0]);
            b = double.Parse(vetor[1]);
            c = double.Parse(vetor[2]);

            delta = (Math.Pow(b,2.0) - (4*a*c));
           
            if(delta < 0.0 || a == 0)
                {
                    Console.WriteLine("Impossível de cálcular: ");
                }
            else
                {
                    r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    
                    Console.WriteLine("Resultado de Delta: " + delta);
                    Console.WriteLine("Resultado do X¹: " + r1.ToString("F5"));
                    Console.WriteLine("Resultado do X²: " + r2.ToString("F5"));
                }

            Console.ReadLine();
        }
    }
}
