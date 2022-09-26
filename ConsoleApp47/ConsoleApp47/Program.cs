using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, fah;
            char resposta;

            do
            {
                Console.WriteLine("Digite a Temperatura em Graus: ");
                c = double.Parse(Console.ReadLine());
                fah = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("A temperatura em Fahrenheit: " + fah);
                Console.WriteLine("Você deseja repetir? (s/n)");
                resposta = char.Parse(Console.ReadLine());
            }
            while (resposta == 's');

            Console.ReadLine();
        }
    }
}
