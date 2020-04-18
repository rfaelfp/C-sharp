using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador = 0;
            Console.WriteLine("Aperte qualquer tecla para encontrar o quinto número maior que 1000 cuja a divisão por 11 tenha resto 5");
            for (i = 1000; i > 1; i++)
            {
                if (i % 11 == 5)
                {
                    contador++;
                    if (contador == 5)
                    {
                        Console.WriteLine($"Resultado {i}");
                        i = 0;
                    }
                }
            }
        }
    }
}
