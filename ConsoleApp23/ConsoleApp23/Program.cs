using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entrada;
            int resto, moeda, quociente, notas;

            Console.WriteLine("Insira o valor a ser trocado: ");
            entrada = double.Parse(Console.ReadLine());

            resto = (int)(entrada * 100.0 + 0.5);

            Console.WriteLine("CÉDULAS:");
            notas = 100;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " notas de R$ 100,00");
            resto = resto % (notas * 100);

            notas = 50;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " notas de R$ 50,00");
            resto = resto % (notas * 100);

            notas = 20;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " notas de R$ 20,00");
            resto = resto % (notas * 100);

            notas = 10;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " notas de R$ 10,00");
            resto = resto % (notas * 100);

            notas = 5;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " notas de R$ 5,00");
            resto = resto % (notas * 100);

            notas = 2;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " notas de R$ 2,00");
            resto = resto % (notas * 100);

            Console.WriteLine("MOEDAS:");
            //MOEDAS
            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moedas de R$ 1,00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moedas de R$ 0,50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moedas de R$ 0,20");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moedas de R$ 0,10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moedas de R$ 0,05");
            resto = resto % moeda;

            moeda = 1;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moedas de R$ 0,01");
            resto = resto % moeda;

            Console.ReadLine();
        }
    }
}
