using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario1;

            Console.WriteLine("Reajuste de Salário");
            Console.WriteLine("Digite o salário: ");
            salario1 = double.Parse(Console.ReadLine());

            if (salario1 < 400.10)
            {
                Console.WriteLine("O seu salário foi reajustado para: " + (salario1 * 1.15));
                Console.WriteLine("Você teve um reajuste de: " + ((salario1 * 1.15) - (salario1)));
                Console.WriteLine("O seu reajuste foi de 15%");
            }
            else if(salario1 < 800.10)
            {
                Console.WriteLine("O seu salário foi reajustado para: " + (salario1 * 1.12));
                Console.WriteLine("Você teve um reajuste de: " + ((salario1 * 1.12) - (salario1)));
                Console.WriteLine("O seu reajuste foi de 12%");
            }
            else if(salario1 < 1200.10)
            {
                Console.WriteLine("O seu salário foi reajustado para: " + (salario1 * 1.10));
                Console.WriteLine("Você teve um reajuste de: " + ((salario1 * 1.10) - (salario1)));
                Console.WriteLine("O seu reajuste foi de 10%");
            }
            else if(salario1 < 2000.10)
            {
                Console.WriteLine("O seu salário foi reajustado para: " + (salario1 * 1.07));
                Console.WriteLine("Você teve um reajuste de: " + ((salario1 * 1.07) - (salario1)));
                Console.WriteLine("O seu reajuste foi de 7%");
            }
            else
            {
                Console.WriteLine("O seu salário foi reajustado para: " + (salario1 * 1.04));
                Console.WriteLine("Você teve um reajuste de: " + ((salario1 * 1.04) - (salario1)));
                Console.WriteLine("O seu reajuste foi de 4%");
            }

            Console.ReadLine();
        }
    }
}
