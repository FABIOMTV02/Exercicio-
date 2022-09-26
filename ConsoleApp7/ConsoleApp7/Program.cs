using System;
using System.Data.SqlTypes;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            double ht, hv, sal;
            Console.WriteLine("Digite seu número de identificação: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua carga horária: ");
            ht = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da sua hora: ");
            hv = double.Parse(Console.ReadLine());
            sal = ht * hv;
            Console.WriteLine();
            Console.WriteLine("NÚMERO DE IDENTIFICAÇÃO = " + id);
            Console.WriteLine();
            Console.WriteLine("Sálario = R$ " + sal.ToString("###,###,##0.00"));

            Console.ReadLine();
        }
    }
}
