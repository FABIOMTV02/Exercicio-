using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string[] vetor = Console.ReadLine().Split(' ');

            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);


            if (a == b && b == c)
            {
                Console.WriteLine("Todos os Vetores são iguais e portanto o menor valor é: " + c);
            }
            else
            {
                if (a < b && a < c)
                {
                    Console.WriteLine("O vetor A é o menor: " + a);
                }
                else
                {
                    if (b < c)
                    {
                        Console.WriteLine("O vetor B é o menor: " + b);
                    }

                    else
                    {
                        Console.WriteLine("O Vetor C é o menor: " + c);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
