using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, quociente;

            Console.WriteLine("Digite uma quantidade em dias para converter em anos: ");
            entrada = int.Parse(Console.ReadLine());

            quociente = entrada / 365;
            Console.WriteLine(quociente + " ano(s).");
            entrada = entrada % 365;

            quociente = entrada / 30;
            Console.WriteLine(quociente + " mes(es).");
            entrada = entrada % 30;

            quociente = entrada / 1;
            Console.WriteLine(quociente + " dia(s).");
            entrada = entrada % 1;

            Console.ReadLine();
        }
    }
}
