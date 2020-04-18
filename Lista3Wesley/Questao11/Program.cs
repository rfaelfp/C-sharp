using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
                double chico = 1.5, juca = 1.1, i;
                int totalAnos = 0;
                for (i = juca; i < chico; i = juca)
                {
                    chico += 0.02;
                    juca += 0.03;
                    totalAnos++;
                }
                Console.Write($"Será necessário {totalAnos} anos para que Juca seja maior que Chico.");
        }
    }
}
