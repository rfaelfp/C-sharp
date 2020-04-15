using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão III da lista VI.");
            int tamanhoArray, i, j;
            Console.Write("Digite o tamanho da matriz quadrada: ");
            tamanhoArray = Convert.ToInt32(Console.ReadLine());
            int[,] meuArray = new int[tamanhoArray, tamanhoArray];
            int[] diagonalPrincial = new int[tamanhoArray];
            for (i = 0; i < tamanhoArray; i++)
            {
                Console.WriteLine();
                for (j = 0; j < tamanhoArray; j++)
                {
                    meuArray[i, j] = getAleatorio();
                    Console.Write(meuArray[i, j] + "\t");
                }
            }
            Console.WriteLine();

            diagonalPrincial = getDiagonalPrincial(meuArray, tamanhoArray, diagonalPrincial);
            Console.Write("Linha diagonal principal: ");
            foreach(int e in diagonalPrincial)
            {
                Console.Write(e + "\t");
            }

        }
        static int getAleatorio()
        {
            Random numeroAleatorio = new Random();
            int retorno = numeroAleatorio.Next(0, 1000);
            return retorno;
        }
        static int[] getDiagonalPrincial(int[,] meuArray, int tamanhoArray, int[] diagonalPrincialParam)
        {
            int i, j, k = 0;
            for (i = 0; i < tamanhoArray; i++)
                for (j = 0; j < tamanhoArray; j++)
                {
                    if (i == j)
                    {
                        diagonalPrincialParam[k] = meuArray[i, j];
                        k++;
                    }
                }
            return diagonalPrincialParam;
        }
    }
}
