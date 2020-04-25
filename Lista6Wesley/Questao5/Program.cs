using System;
class Program
{
    static void Main(string[] args)
    {
        int tamanho;
        Console.Write("Digite o tamanho da matriz quadrada: ");
        tamanho = Convert.ToInt32(Console.ReadLine());
        int[,] minhaMatriz = new int[tamanho, tamanho];
        int[,] minhaMatriz2 = new int[tamanho, tamanho];

        minhaMatriz = preencherMatriz(minhaMatriz);
        Console.WriteLine("Primeira Matriz");
        printMatriz(minhaMatriz);
        minhaMatriz2 = preencherMatriz(minhaMatriz2);
        Console.WriteLine("Segunda Matriz");
        printMatriz(minhaMatriz2);
        minhaMatriz = matrizAlterada(minhaMatriz, minhaMatriz2);
        Console.WriteLine("Soma das duas matrizes");
        printMatriz(minhaMatriz);
    }
    static int[,] preencherMatriz(int[,] minhaMatriz)
    {
        int i, j;
        Random aleatorio = new Random();
        for (i = 0; i < minhaMatriz.GetLength(0); i++)
            for (j = 0; j < minhaMatriz.GetLength(0); j++)
                minhaMatriz[i, j] = aleatorio.Next(0, 1000);
        return minhaMatriz;
    }
    static void printMatriz(int[,] minhaMatriz)
    {
        int i, j;
        for (i = 0; i < minhaMatriz.GetLength(0); i++)
        {
            Console.WriteLine();
            for (j = 0; j < minhaMatriz.GetLength(0); j++)
                Console.Write(minhaMatriz[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static int[,] matrizAlterada(int[,] minhaMatriz, int[,] minhaMatriz2)
    {
        int i, j;
        for (i = 0; i < minhaMatriz.GetLength(0); i++)
            for (j = 0; j < minhaMatriz.GetLength(0); j++)
                minhaMatriz[i, j] += minhaMatriz2[i, j];
        return minhaMatriz;
    }
}