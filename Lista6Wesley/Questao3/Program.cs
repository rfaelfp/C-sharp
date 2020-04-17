using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoArray;
            Console.Write("Digite o tamanho da matriz quadrada: ");
            tamanhoArray = Convert.ToInt32(Console.ReadLine());
            int[,] meuArray = new int[tamanhoArray, tamanhoArray];

            getAleatorio(meuArray);
            printMeuArray(meuArray);
            printDiagonal(getDiagonalPrincial(meuArray));
            printDiagonal(getDiagonalSecundaria(meuArray));
        }
        static int[,] getAleatorio(int[,] meuArray)
        {
            int i, j;
            Random numeroAleatorio = new Random();
            for (i = 0; i < meuArray.GetLength(0); i++)
                for (j = 0; j < meuArray.GetLength(0); j++)
                    meuArray[i, j] = numeroAleatorio.Next(0, 1000);
            return meuArray;
        }
        static void printMeuArray(int[,] meuArray)
        {
            int i, j;
            for (i = 0; i < meuArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < meuArray.GetLength(0); j++)
                    Console.Write(meuArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
        static int[] getDiagonalPrincial(int[,] meuArray)
        {
            Console.Write("Linha diagonal principal: ");
            int i, j, k = 0;
            int[] diagonalPrincial = new int[meuArray.GetLength(0)];
            for (i = 0, j = 0; i < meuArray.GetLength(0); i++, j++)

            {
                diagonalPrincial[k] = meuArray[i, j];
                k++;
            }
            return diagonalPrincial;
        }
        static int[] getDiagonalSecundaria(int[,] meuArray)
        {
            Console.Write("Linha diagonal secundária: ");
            int i, j, k = 0;
            int[] diagonalSecundaria = new int[meuArray.GetLength(0)];
            for (i = 0, j = meuArray.GetLength(0) - 1; i < meuArray.GetLength(0); i++, j--)
            {
                diagonalSecundaria[k] = meuArray[i, j];
                k++;
            }
            return diagonalSecundaria;
        }
        static void printDiagonal(int[] diagonal)
        {
            foreach (int e in diagonal)
            {
                Console.Write(e + "\t");
            }
            Console.WriteLine();
        }
    }
}
