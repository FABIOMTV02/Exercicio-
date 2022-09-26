using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, quociente, nota, resto;
            Console.WriteLine("Entre com o valor para saque: ");
            entrada = int.Parse(Console.ReadLine());

            resto = entrada;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 100,00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 50,00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 20,00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 10,00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 5,00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 2,00");
            resto = resto % nota;

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine("Foram " + quociente + " nota(s) de R$ 1,00");
            resto = resto % nota;

            Console.ReadLine();
        }
    }
}
