using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            preencheVet(vet);
            printVet(vet);
            printNeg(vet);
            somaVet(vet);
            media(vet);
        }

        static void preencheVet(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o vetor: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void printVet(int[] vet)
        {
            Console.Write("Vetor: ");
            foreach(int e in vet)
            {
                Console.Write(e + ", ");
            }
            Console.WriteLine();
        }
        static void printNeg(int[] vet)
        {
            Console.Write("Números negativos: ");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] < 0)
                Console.Write(vet[i] + ", ");
            }
            Console.WriteLine();
        }
        static void somaVet(int[] vet)
        {
            int soma = 0;
            for (int i = 0; i < vet.Length; i++)
                soma += vet[i];
            Console.WriteLine("Soma: " + soma);
        }
        static void media(int[] vet)
        {
            int soma = 0;
            for (int i = 0; i < vet.Length; i++)
                soma += vet[i];
            Console.WriteLine($"A média é {soma / vet.Length}");
        }
    }
}
