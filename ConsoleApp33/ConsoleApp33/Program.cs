using System;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaentrada, horasaida;

            Console.WriteLine("Digite a hora de entrada: ");
            horaentrada = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora de saída: ");
            horasaida = int.Parse(Console.ReadLine());

            if(horaentrada < horasaida)
            {
                Console.WriteLine("O jogo durou " + (horasaida - horaentrada) + " horas");
            }
            else
            {
                Console.WriteLine("O jogo durou " + (horasaida + 24 - horaentrada) + " horas");
            }

            Console.ReadLine();
        }
    }
}
