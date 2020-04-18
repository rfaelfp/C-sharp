using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite os valores do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Vetor:");
            foreach (int e in vetor)
            {
                Console.Write(e + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Vetor multiplicado por 3:");
            for (i = 0; i < vetor.Length; i++)
            {
                vetor[i] *= 3;
                Console.Write(vetor[i] + ", ");
            }
        }
    }
}
