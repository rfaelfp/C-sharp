using System;

class Program
{
    static void Main(string[] args)
    {
        int tamanhoArray;
        Console.Write("Digite o tamanho da matriz quadrada: ");
        tamanhoArray = Convert.ToInt32(Console.ReadLine());
        int[,] meuArray = new int[tamanhoArray, tamanhoArray];

        meuArray = preencherArray(meuArray);
        Console.WriteLine("Matriz");
        printArray(meuArray);
        arrayAlterada(meuArray);
        Console.WriteLine("Matriz alterada");
        printArray(meuArray);
    }
    static int[,] preencherArray(int[,] meuArray)
    {
        Random aleatorios = new Random();
        int i, j;
        for (i = 0; i < meuArray.GetLength(0); i++)
            for (j = 0; j < meuArray.GetLength(0); j++)
                meuArray[i, j] = aleatorios.Next(0, 1001);
        return meuArray;
    }
    static void printArray(int[,] meuArray)
    {
        int i, j;
        for (i = 0; i < meuArray.GetLength(0); i++)
        {
            Console.WriteLine();
            for (j = 0; j < meuArray.GetLength(0); j++)
                Console.Write(meuArray[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static int[,] arrayAlterada(int[,] meuArray)
    {

        int i, j, contador = 0;
        for (i = 0; i < meuArray.GetLength(0); i++)
        {
            contador++;
            for (j = -1 + contador; j < meuArray.GetLength(0); j++)
                meuArray[i, j] = meuArray[i, j] * -1;
        }
        return meuArray;
    }

}