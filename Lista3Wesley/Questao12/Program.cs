using System;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
                int numeroEntrada, i, contador = 0;
                
                Console.Write("Digite o número para saber se é primo: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= numeroEntrada; i++)
                {
                    if (numeroEntrada % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2 || numeroEntrada == 0)
                {
                    Console.WriteLine($"O número {numeroEntrada} é primo!");
                }
                else
                {
                    Console.WriteLine($"O número {numeroEntrada} não é primo!");
                }
        }
    }
}
