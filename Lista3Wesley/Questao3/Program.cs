using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0, contador = 0, i, resultado;

            for (i = 1; i > 0; i++)
            {
                Console.WriteLine("Digite os números: ");
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 1)
                {
                    numeros += i;
                    contador++;
                }
            }
            resultado = numeros / contador;
            Console.WriteLine(resultado);
        }
    }
}
