using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite o limete: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(metodoElevado(n));
            Console.WriteLine(metodoLog(n));
            Console.WriteLine(metodoCos(n));
        }
        static double metodoElevado(int n)
        {
            int i;
            double multi = 1;
            for (i = 1; i <= n; i++)
                multi *= i / Math.Sqrt(i);
            return multi;
        }
        static double metodoLog(int n)
        {
            int i;
            double multi = 1;
            for (i = 0; i <= n; i++)
                multi *= Math.Exp(Math.Log(i + 12));
            return multi;
        }
        static double metodoCos(int n)
        {
            int i;
            double multi = 1;
            for (i = 3; i <= n; i++)
                multi *= Math.Pow(Math.Cos(i / 3), 4);
            return multi;
        }
    }
}
