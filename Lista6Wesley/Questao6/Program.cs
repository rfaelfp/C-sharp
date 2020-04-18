using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Console.Write("Digite o tamanho da matriz quadrada: ");
            qtd = Convert.ToInt32(Console.ReadLine());
            int[,] mat1 = new int[qtd, qtd];
            int[,] mat2 = new int[qtd, qtd];

            mat1 = getMat(mat1);
            printMat(mat1);
            mat2 = getMat(mat2);
            printMat(mat2);
            Console.WriteLine("Resultado");
            printMat(modificaMat(mat1, mat2));
        }
        static int[,] getMat(int[,] mat1)
        {
            int i, j;
            Random numRan = new Random();
            for (i = 0; i < mat1.GetLength(0); i++)
                for (j = 0; j < mat1.GetLength(0); j++)
                    mat1[i, j] = numRan.Next(0, 10);
            return mat1;
        }
        static void printMat(int[,] mat1)
        {
            int i, j;
            for (i = 0; i < mat1.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < mat1.GetLength(0); j++)
                    Console.Write(mat1[i, j] + "\t");
            }
            Console.WriteLine();
        }
        static int[,] modificaMat(int[,] mat1, int[,] mat2)
        {
            int i, j, k;
            int[,] mat3 = new int[mat1.GetLength(0), mat1.GetLength(0)];
            for (k = 0; k < mat3.GetLength(0); k++)
                for (i = 0; i < mat3.GetLength(0); i++)
                    mat3[k, k] = 0;

            for (i = 0; i < mat1.GetLength(0); i++)
                for (j = 0; j < mat1.GetLength(0); j++)
                    for (k = 0; k < mat1.GetLength(0); k++)
                        mat3[i, j] += mat1[i, k] * mat2[k, j];
            return mat3;
        }
    }
}
