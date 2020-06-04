using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int total = 0;
            
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite os valores do vetor: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Vetor: ");
            foreach (int e in vet)
            {
                Console.Write(e + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Os números negativos do vetor: ");
            for (int i = 0; i < vet.Length; i++)
            {

                if (vet[i] < 0)
                {
                    Console.Write(vet[i] + ", ");
                }
            }
            for (int i = 0; i < vet.Length; i++)
            {
                total += vet[i];
            }
            Console.WriteLine("A soma dos elementos do vetor é " + total);

            Console.WriteLine($"A média aritimética é {total / vet.Length}");
        }
    }
}
