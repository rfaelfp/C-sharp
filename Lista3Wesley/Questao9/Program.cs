using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
                int numeroLimite, i, numero1 = 0, numero2 = 1, total = 0;
                Console.Write("Digite o número limite da sequencia Fibonacci: ");
                numeroLimite = Convert.ToInt32(Console.ReadLine());
                Console.Write("0, 1, ");
                for (i = 1; i <= numeroLimite; i = i)
                {
                    if (numero1 < numero2)
                    {
                        numero1 = i;
                    }
                    else
                    {
                        numero2 = i;
                    }
                    if (i <= numeroLimite)
                    {
                        Console.Write($"{i}, ");
                        total += i;
                        i = numero1 + numero2;
                    }
                }
                total += 1;
                Console.Write("O total é " + total);
        }
    }
}
