using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double codigo, quantidade;

            Console.WriteLine("Dígite o código do Produto: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                Console.WriteLine("Digite a Quantidade");
                quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Total R$:" + (codigo*4.00) * (quantidade));
            }
            else if (codigo == 2)
            {
                Console.WriteLine("Digite a Quantidade");
                quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Total R$:" + (codigo * 4.50 / 2) * (quantidade));
            }
            else if (codigo == 3)
            {
                Console.WriteLine("Digite a Quantidade");
                quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Total R$:" + (codigo * 5.00 / 3) * (quantidade));
            }
            else if (codigo == 4)
            {
                Console.WriteLine("Digite a Quantidade");
                quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Total R$:" + (codigo * 2.00 / 4) * (quantidade));
            }
            else if (codigo == 5)
            {
                Console.WriteLine("Digite a Quantidade");
                quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Total R$:" + (codigo * 1.50 / 5) * (quantidade));
            }




            Console.ReadLine();
        }
    }
}
