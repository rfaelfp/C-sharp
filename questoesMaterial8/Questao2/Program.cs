using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];
            int i, j, contImpar = 0, soma = 0, arit = 0, somaNegativos = 0;
            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite os valores da matriz: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Matriz informada: ");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < matriz.GetLength(1); j++)
                    Console.Write(matriz[i, j] + "\t");
            }
            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (Math.Abs(matriz[i, j]) % 2 == 1)
                        contImpar++;
                    if (matriz[i, j] > 0)
                    {
                        soma += matriz[i, j];
                        arit++;
                    }
                    if (matriz[i, j] < 0)
                        somaNegativos += Math.Abs(matriz[i, j]);
                }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A quantidade de números impares: " + contImpar);
            Console.Write("As posições dos números pares: ");
            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                        Console.Write($"[{i}, {j}], ");
                }
            Console.WriteLine();
            Console.WriteLine("A média aritmética dos números positivos: " + (double)soma / (double)arit);
            Console.WriteLine("O quadrado da soma dos números negativos: " + Math.Pow((double)somaNegativos, 2));
        }
    }
}
