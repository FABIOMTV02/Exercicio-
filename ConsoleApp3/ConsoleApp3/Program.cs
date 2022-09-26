using System;
using System.Formats.Asn1;

namespace ConsoleApp3
{
   
    internal class Program
    {
        
        static void Main(string[] args)
            {
            double largura, comprimento, precom2, area, preco;
            
            Console.WriteLine("Cálculo da área e o preço de um terreno");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da largura do terreno: ");
            largura = double.Parse(Console.ReadLine());

            area = largura * comprimento;
      
            Console.WriteLine("À área do terreno é de: " + area + "m²");
            Console.WriteLine();

            Console.WriteLine("Digite o valor do preço do m²: ");
            precom2 = double.Parse(Console.ReadLine());

            preco = area * precom2;

            Console.WriteLine("O preço do terreno é de: " + preco.ToString("###,###,##0.00"));


            Console.ReadLine();
        }
    }
}
