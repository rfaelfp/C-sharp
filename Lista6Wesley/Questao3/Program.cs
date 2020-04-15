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
            int[] diagonalPrincial = new int[tamanhoArray];
            int[] diagonalSecundaria = new int[tamanhoArray];

            meuArray = getAleatorio(meuArray, tamanhoArray);

            printMeuArray(meuArray, tamanhoArray);
            Console.WriteLine();

            diagonalPrincial = getDiagonalPrincial(meuArray, tamanhoArray, diagonalPrincial);
            Console.Write("Linha diagonal principal: ");
            printDiagonal(diagonalPrincial);

            Console.WriteLine();
            diagonalSecundaria = getDiagonalSecundaria(meuArray, tamanhoArray, diagonalSecundaria);
            Console.Write("Linha diagonal secundária: ");
            printDiagonal(diagonalSecundaria);

            Console.WriteLine();
            Console.WriteLine();
        }
        static int[,] getAleatorio(int[,] meuArray, int tamanhoArray)
        {
            int i, j; 
            Random numeroAleatorio = new Random();
            for (i = 0; i < tamanhoArray; i++)
                for (j = 0; j < tamanhoArray; j++)
                    meuArray[i, j] = numeroAleatorio.Next(0, 1000);
            return meuArray;
        }
        static void printMeuArray(int[,] meuArray, int tamanhoArray)
        {
            int i, j;
            for (i = 0; i < tamanhoArray; i++)
            {
                Console.WriteLine();
                for (j = 0; j < tamanhoArray; j++)
                    Console.Write(meuArray[i, j] + "\t");
            }
        }
        static int[] getDiagonalPrincial(int[,] meuArray, int tamanhoArray, int[] diagonalPrincialParam)
        {
            int i, j, k = 0;
            for (i = 0, j = 0; i < tamanhoArray; i++, j++)

                {
                        diagonalPrincialParam[k] = meuArray[i, j];
                        k++;
                }
            return diagonalPrincialParam;
        }
        static int[] getDiagonalSecundaria(int[,] meuArray, int tamanhoArray, int[] diagonalSecundariaParam)
        {
            int i, j, k = 0;
            for (i = 0, j = tamanhoArray - 1; i < tamanhoArray; i++, j--)
            {
                diagonalSecundariaParam[k] = meuArray[i, j];
                k++;
            }
            return diagonalSecundariaParam;
        }
        static void printDiagonal(int[] diagonal)
        {
            foreach(int e in diagonal)
            {
                Console.Write(e + "\t");
            }
        }
    }
}
