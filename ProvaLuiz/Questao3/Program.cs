using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n, i, contador = 0;
            Console.Write("Informe um número maior ou igual a 10: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 10)
            {
                Console.WriteLine($"O número {n} não é válido!");
            }
            else
            {
                for (i = 1; i < 10; i++)
                {
                    if (n % i == 0)
                        contador++;
                }
            Console.WriteLine($"O número {n} possui {contador} divisor(es).");
            }
        }

    }
}
