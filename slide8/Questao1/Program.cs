using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];
            int i, j;
            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite os valores da matriz: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Matriz: ");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < matriz.GetLength(1); j++)
                    Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Matriz modificada: ");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < matriz.GetLength(1); j++)
                    Console.Write(Math.Pow(matriz[i, j], 2) + "\t");
            }
        }
    }
}
