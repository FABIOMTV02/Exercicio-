using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada;

            Console.WriteLine("Dígite a Senha: ");
            Console.WriteLine();
            entrada = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while(entrada != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.WriteLine("Dígite a Senha Novamente: ");
                Console.WriteLine();
                entrada = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Senha Correta...");

            Console.ReadLine();
        }
    }
}
