using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, resultado;
            Console.WriteLine("Digite o valor limite da tabuada: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                resultado = i * n;
                Console.WriteLine($"{i} x {n} = {resultado}");
            }
        }
    }
}
