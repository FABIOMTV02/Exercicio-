using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1, p2; //Código Peças
            int n1, n2; //Unidade de Peças
            double v1, v2, vt1, vt2, valototal; //Valor Unitário de Cada Peça
            double valortotal; //Valor Total 
            
            Console.WriteLine("Digite o código da 1° Peça: ");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da 1° Peça: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da 1° Peça: ");
            v1 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Digite o código da 2° Peça: ");
            p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da 2° Peça: ");
            n2 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Digite o valor da 2° Peça: ");
            
            v2 = int.Parse(Console.ReadLine());
            vt1 = v1 * n1;
            vt2 = v2 * n2;
            valortotal = vt1 + vt2;

            Console.WriteLine("O valor total da compra: " + valortotal);


            Console.ReadLine();
        }
    }
}
