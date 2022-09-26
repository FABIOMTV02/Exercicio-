using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;
            Console.WriteLine("Dígite a 1° nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dígite a 2° nota: ");
            nota2 = double.Parse(Console.ReadLine());

            soma = (nota1 + nota2) / 2;

            Console.WriteLine("Nota final = " + soma.ToString("F1"));
            if (soma > 60)
                {
                    Console.WriteLine("Aprovado");
                }
            else
                {
                    Console.WriteLine("Reprovado");
                }

            Console.ReadLine();
        }
    }
}
