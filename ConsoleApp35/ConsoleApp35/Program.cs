using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entrada;

            Console.WriteLine("Digite o valor para calcula o Intervalo: ");
            entrada = double.Parse(Console.ReadLine());

            if (entrada < 0 || entrada > 100)
            {
                Console.WriteLine("O valor está fora do intervalo.");
            }
            else if (entrada <= 25.00)
            {
                Console.WriteLine("O intervalo é de [0-25]");
            }
            else if (entrada <= 50.00)
            {
                Console.WriteLine("O intervalo é de [25-50]");
            }
            else if (entrada <= 75.00)
            {
                Console.WriteLine("O intervalo é de [50-75]");
            }
            else if (entrada < 100.00)
            {
                Console.WriteLine("O intervalo é de [75-100]");
            }



            Console.ReadLine();
        }
    }
}
