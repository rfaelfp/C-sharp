using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite o limite: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(metodoElevado(n));
            Console.WriteLine(metodoSen(n));
            Console.WriteLine(metodoLog(n));
        }
        static double metodoElevado(int n)
        {
            int i;
            double soma = 0;
            for (i = 0; i <= n; i++)
                soma += Math.Sqrt(i);
            return soma;
        }
        static double metodoSen(int n)
        {
            int i;
            double soma = 0;
            for (i = 0; i <= n; i++)
                soma += Math.Sin(i + 5);
            return soma;
        }
        static double metodoLog(int n)
        {
            int i;
            double soma = 0;
            for (i = 0; i <= n; i++)
                soma += Math.Log10(Math.Pow(2, i));
            return soma;
        }
    }
}
