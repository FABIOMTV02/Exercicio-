using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaentrada, horafim, periodo1, periodo2;

            Console.WriteLine("Digite a hora de Entrada: ");
            horaentrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora de Saída: ");
            horafim = int.Parse(Console.ReadLine());

            periodo1 = ((horaentrada - 24) * (-1) + horafim);
            periodo2 = (horafim - horaentrada);

            if (horaentrada > horafim )
            {
                Console.WriteLine(periodo1);
            }
            else if (horafim > horaentrada)
            {
                Console.WriteLine(periodo2);
            }


            Console.ReadLine();
        }
    }
}
