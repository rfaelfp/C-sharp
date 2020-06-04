using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = new int[10];
        preencheVet(vet);
        printVet(vet);
        printNeg(vet);
        somaVet(vet);
        media(vet);
        Console.Write("Buscar número no vetor: ");
        int numVer = Convert.ToInt32(Console.ReadLine());
        if (verificarNum(vet, numVer) != -1)
            Console.Write($"O número {numVer} existe no vetor!");
        else
            Console.Write($"O número {numVer} não existe no vetor!");

        

    }

    static void preencheVet(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write("Digite o vetor: ");
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }

    }
    static void printVet(int[] vet)
    {
        Console.Write("Vetor: ");
        foreach (int e in vet)
        {
            Console.Write(e + ", ");
        }
        Console.WriteLine();
    }
    static void printNeg(int[] vet)
    {
        Console.Write("Números negativos: ");
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] < 0)
                Console.Write(vet[i] + ", ");
        }
        Console.WriteLine();
    }
    static void somaVet(int[] vet)
    {
        int soma = 0;
        for (int i = 0; i < vet.Length; i++)
            soma += vet[i];
        Console.WriteLine("Soma: " + soma);
    }
    static void media(int[] vet)
    {
        int soma = 0;
        for (int i = 0; i < vet.Length; i++)
            soma += vet[i];
        Console.WriteLine($"A média é {soma / vet.Length}");
    }
    static int verificarNum(int[] vet, int num)
    {
        int cont = 0;
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] == num)
            {
                cont = i;
                break;
            }
            else
                cont = -1;
        }
        return cont;
    }
}

