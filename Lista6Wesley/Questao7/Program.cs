using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva um algoritmo que armazene em uma matriz a distância das estradas que ligam 4 cidades vizinhas.");


        int[,] matriz = new int[4, 4];
        int result;
        preencherMatriz(matriz);
        qtdEstradas(matriz);
        printMatriz(matriz);
        while (true)
        {
            result = retornaDistancia(matriz);
            if (result != 0)
                Console.WriteLine($"A distância entre as cidades é {result} quilometros.");
            else
                Console.WriteLine($"Não há estradas entre as cidades");

        }
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
                    matriz[i, j] = 0;
                else
                {
                    Console.Write($"Digite as distância entre a cidade {cidade1.Substring(i, 1)} e a {cidades2.Substring(controleCidade, 1)}: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    controleCidade++;
                }
            }
        return matriz;
    }
    static void printMatriz(int[,] matriz)
    {
        int i, j;
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine();
            for (j = 0; j < matriz.GetLength(0); j++)
                Console.Write(matriz[i, j] + "\t");
        }
        Console.WriteLine();
    }
    static void qtdEstradas(int[,] matriz)
    {
        int i, j, contA = 0, contB = 0, contC = 0, contD = 0;
        for (i = 0; i < matriz.GetLength(0); i++)
            for (j = 0; j < matriz.GetLength(0); j++)
            {
                if (matriz[i, j] != 0)
                {
                    if (i == 0)
                        contA++;
                    else if (i == 1)
                        contB++;
                    else if (i == 2)
                        contC++;
                    else
                    {
                        contD++;
                    }
                }
            }
        Console.WriteLine($"A cidade A é ligada por {contA} estradas.");
        Console.WriteLine($"A cidade B é ligada por {contB} estradas.");
        Console.WriteLine($"A cidade C é ligada por {contC} estradas.");
        Console.WriteLine($"A cidade D é ligada por {contD} estradas.");
    }
    static int retornaDistancia(int[,] matriz)
    {
        int i, j;
        char cidade1, cidade2;
        string cidades = "abcd";
        Console.Write("Digite a origem: ");
        cidade1 = Convert.ToChar(Console.ReadLine());
        Console.Write("Digite o destino: ");
        cidade2 = Convert.ToChar(Console.ReadLine());


        for (i = 0; cidades[i] != cidade1; i++) ;
        for (j = 0; cidades[j] != cidade2; j++) ;
        return matriz[i, j];
    }
}