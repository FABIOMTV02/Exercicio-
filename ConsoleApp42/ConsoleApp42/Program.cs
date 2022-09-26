using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, soma, cont;
            cont = 0;
            soma = 0;

            Console.WriteLine("Dígite o valor de A:");
            entrada = int.Parse(Console.ReadLine());
            
            while(entrada >= 0)
            {
                soma = soma + entrada;
                cont = cont + 1;

                Console.WriteLine("Dígite o valor de A:");
                entrada = int.Parse(Console.ReadLine());
            }

            if(cont == 0)
            {
                Console.WriteLine("Ímpossível de cálcular");
            }
            else
            {
                Console.WriteLine("Média de Idade é de: " + (soma / cont));
                Console.WriteLine("E teve " + cont + " váriaveis.");
            }

           

            Console.ReadLine();
        }
    }
}
