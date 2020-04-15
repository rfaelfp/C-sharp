using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] minhaMatriz = new int[4, 5];
            getNumerosAleatorios(minhaMatriz);
            printMatriz(minhaMatriz);
            printMatrizPar(minhaMatriz);
        }
        static void getNumerosAleatorios(int[,] minhaMatrizRetorno)
        {
            int i, j;
            Random numerosAleatorios = new Random();
            for (i = 0; i <= 3; i++)
                for (j = 0; j <= 4; j++)
                {
                    minhaMatrizRetorno[i, j] = numerosAleatorios.Next(0, 101);
                }
        }
        static void printMatriz(int[,] minhaMatrizRetorno)
        {
            int i, j;
            Console.Write("Os valores da matriz 4x5 são: ");
            for (j = 0; j <= 4; j++)
            {
                Console.WriteLine("\n");
                for (i = 0; i <= 3; i++)
                {
                    Console.Write(minhaMatrizRetorno[i, j] + ", ");
                }
            }
        }
        static void printMatrizPar(int[,] minhaMatrizRetorno)
        {
            int i, j;
            Console.WriteLine();
            Console.Write("Os valores da matriz de linhas e colunas pares são: ");
            for (j = 0; j <= 4; j++)
            {
                Console.WriteLine();
                for (i = 0; i <= 3; i++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write(minhaMatrizRetorno[i, j] + ", ");
                    }
                }
            }
        }
    }

}
