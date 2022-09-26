using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            double conta, extra, excedente;
            
            Console.WriteLine("Dígite a quantidade de minutos consumidos no mês: ");
            m = int.Parse(Console.ReadLine());

            excedente = m - 100;
            extra = excedente * 2;
            conta = 50;
            if (m > 100)
            {
                conta = conta + (excedente * 2);
                Console.WriteLine("Você ultrapassou sua franquia em " + excedente +
                    " minutos, aumentando sua fatura em " + extra + ",00 Reais");
                Console.WriteLine("E o valor total foi de: " + conta + ",00 Reais");
            }
            else
            {
                Console.WriteLine("Você não consumiu toda sua franquia, e o valor foi de: " + conta);
            }


            Console.ReadLine();
        }
    }
}
