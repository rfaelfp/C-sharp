using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] numeros = new int[5];
                int i, soma = 0, maiorNumero = 0, menorNumero = Int32.MaxValue;
                for (i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Digite 5 números: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    soma += numeros[i];
                    if (numeros[i] > maiorNumero)
                    {
                        maiorNumero = numeros[i];
                    }
                    if (numeros[i] < menorNumero)
                    {
                        menorNumero = numeros[i];
                    }
                }
                Console.WriteLine($"O maior número é {maiorNumero}");
                Console.WriteLine($"O menor número é {menorNumero}");
                soma /= numeros.Length;
                Console.WriteLine($"A média aritimética é {soma}");
        }
    }
}
