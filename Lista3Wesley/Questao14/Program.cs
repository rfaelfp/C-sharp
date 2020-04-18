using System;

namespace Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
                int i, quantidadeCasaXadrez = 64;
                double quantidade = 1, total = 1;
                Console.WriteLine("Programa para calcular quantidade de grãos de trigo em um tabuleiro");
                for (i = 1; i <= quantidadeCasaXadrez; i++)
                {
                    quantidade *= 2;
                    total += quantidade;
                }
                Console.Write($"O monge receberá {total} grãos da rainha.");
        }
    }
}
