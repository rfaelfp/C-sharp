using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.Write("Escreva o limite: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"S = {MinhaFuncao(n)}");
        }
        static double MinhaFuncao(double n)
        {
            int i;
            double result = 0;
            for (i = 1; i <= n; i++)
            {
                result += 1 / Fatorial(i);
            }
            return result;
        }
        static double Fatorial(double n)
        {
            double i;
            for (i = n - 1; i > 0; i--)
                n *= i;
            return n;
        }
    }
}
