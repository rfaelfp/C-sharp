using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva um algoritmo que armazene em uma matriz a distância das estradas que ligam 4 cidades vizinhas.");


        int[,] matriz = new int[4, 4];
        preencherMatriz(matriz);
        printMatriz(matriz);
    }
    static int[,] preencherMatriz(int[,] matriz)
    {
        int i, j;
        string cidade1 = "ABCD";
        string cidades2 = "BCDACDABDABC";
        int controleCidade = 0;
        for (i = 0; i < matriz.GetLength(0); i++)
            for (j = 0; j < matriz.GetLength(0); j++)
            {
                if (i == j)
                {
                    matriz[i, j] = 0;
                }
                else
                {
                    Console.Write($"Digite as distância entre a cidade {cidade1.Substring(i, 1)} e a {cidades2.Substring(controleCidade, 1)}: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    controleCidade++;
                }
            }
        return matriz;
    }
    static void printMatriz(int [,] matriz)
    {
        int i, j;
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine();
            for (j = 0; j < matriz.GetLength(0); j++)
                Console.Write(matriz[i, j] + "\t");
        }
    }
}