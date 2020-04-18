using System;
class Program
{
    static void Main(string[] args)
    {
        int[] meuVetorEntrada = new int[10];
        Console.WriteLine("Questão do vetor");
        getVetor(meuVetorEntrada);
        printVetor(meuVetorEntrada);
        printVetorInverso(meuVetorEntrada);
        printVetorMeioInicio(meuVetorEntrada);
        printVetorMeioFim(meuVetorEntrada);
    }
    static void getVetor(int[] meuArray)
    {
        int[] meuVetor = new int[10];
        for (int i = 0; i < meuArray.Length; i++)
        {
            Console.Write("Digite os valores para serem inserido no vetor: ");
            meuArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void printVetor(int[] meuArray)
    {
        Console.Write("O vetor informado é: ");
        foreach (int elemento in meuArray)
        {
            Console.Write(elemento + ", ");
        }
    }
    static void printVetorInverso(int[] meuArray)
    {
        Console.WriteLine();
        Console.Write("O vetor de trás para frente é: ");
        for (int i = meuArray.Length - 1; i >= 0; i--)
        {

            Console.Write(meuArray[i] + ", ");
        }
    }
    static void printVetorMeioInicio(int[] meuArray)
    {
        Console.WriteLine();
        Console.Write("O vetor do meio para o início é: ");
        for (int i = (meuArray.Length / 2) - 1; i >= 0; i--)
        {
            Console.Write(meuArray[i] + ", ");
        }
    }
    static void printVetorMeioFim(int[] meuArray)
    {
        Console.WriteLine();
        Console.Write("O vetor do meio para o fim é: ");
        for (int i = (meuArray.Length / 2); i < meuArray.Length; i++)
        {
            Console.Write(meuArray[i] + ", ");
        }
    }
}