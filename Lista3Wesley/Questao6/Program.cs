using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
		int numero, i, valorConsole;
                Console.Write("Digite o número que o fatorial será iniciado: ");
                numero = Convert.ToInt32(Console.ReadLine());
                valorConsole = numero;
                if (numero < 0)
                {
                    Console.Write("O número é inválido");
                }
                else if (numero == 0)
                {
                    Console.Write("O fatorial de 0 é 1");
                }
                else
                {
                    for (i = (numero - 1); i > 1; --i)
                    {
                        numero *= (i);

                    }
                    Console.Write($"!{valorConsole} = {numero}");
                }
        }
    }
}
