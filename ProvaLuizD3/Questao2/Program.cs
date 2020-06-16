using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eixoX, eixoY;

            do
            {
                Console.Write("Digite a quantidade de linhas: ");
                eixoX = Convert.ToInt32(Console.ReadLine());
            } while (VerificaTam(eixoX) == false);
            do
            {
                Console.Write("Digite a quantidade de colunas: ");
                eixoY = Convert.ToInt32(Console.ReadLine());
            } while (VerificaTam(eixoY) == false);

            int[,] matriz = new int[eixoX, eixoY];
            PreencherMatriz(eixoX, eixoY, matriz);
            PrintMatriz(eixoX, eixoY, matriz);
            if (eixoX == eixoY)
                PrintLinhas(matriz, Diagonal(matriz));
            else
                Console.WriteLine("Não é uma matriz quadrada.");

        }
        static bool VerificaTam(int tam)
        {
            bool ver = false;
            if (tam > 0)
                ver = true;
            return ver;
        }
        static void PreencherMatriz(int eixoX, int eixoY, int[,]matriz)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < eixoX; i++)
                for (int j = 0; j < eixoY; j++)
                    matriz[i, j] = aleatorio.Next(1, 101);
        }
        static void PrintMatriz(int eixoX, int eixoY, int[,] matriz)
        {
            Console.Write("Matriz:");
            for (int i = 0; i < eixoX; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < eixoY; j++)
                    Console.Write($"{matriz[i, j]}\t");
            }
            Console.WriteLine("\n");
        }

        static int Diagonal(int[,]matriz)
        {
            int somaDiagonal = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    if (i == j)
                        somaDiagonal += matriz[i, j];
            Console.WriteLine("Soma da diagonal principal: " + somaDiagonal);
            return somaDiagonal;

        }
        static void PrintLinhas(int[,]matriz, int diagonal)
        {
            Console.Write("As linhas possuem  somatório inferior ao da diagonal principal: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int soma = 0;
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    soma += matriz[i, j];
                    if (j == (matriz.GetLength(0) - 1) && soma < diagonal)
                        Console.Write(i + ", ");
                }

            }

        }
    }
}
