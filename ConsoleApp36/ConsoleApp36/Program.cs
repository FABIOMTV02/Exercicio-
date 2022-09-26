using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, exame, mediaexame;

            Console.WriteLine("Cálculo de Média:");
            Console.WriteLine();
            Console.WriteLine("Dígite a Nota do 1° Bimestre: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota do 2° Bimestre: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota do 3° Bimestre: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota do 4° Bimestre: ");
            n4 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            media = ((n1*2) + (n2*3) + (n3*4) + (n4*1)) / 10;
            

            if (media < 0 || media > 10)
            {
                Console.WriteLine("Valores não correspondem.");
            }
            else if (media >= 5.00 && media < 6.99)
            {
                Console.WriteLine("Aluno em Exame");
                Console.WriteLine("Dígite a nota do Exame: ");
                exame = float.Parse(Console.ReadLine());
                mediaexame = (exame + media) / 2;
                if (mediaexame > 5.00)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aluno Aprovado");
                    Console.WriteLine("Nota do Exame: " + exame);
                    Console.WriteLine("Média Final: " + mediaexame);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Aluno Reprovado");
                    Console.WriteLine("Nota do Exame: " + exame);
                    Console.WriteLine("Média Final: " + mediaexame);
                }
            }
            else if (media < 5.00)
            {
                Console.WriteLine("Aluno Reprovado.");
                
                Console.WriteLine("Média: " + media.ToString("F1"));
            }
            else if (media > 7.00)
            {
                Console.WriteLine("Aluno Aprovado.");
                
                Console.WriteLine("Média: " + media.ToString("F1"));
            }
                


            
            

            Console.ReadLine();

        }
    }
}
