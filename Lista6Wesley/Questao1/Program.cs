using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Questão I da lista IV.");
        int quantidadeVetor, i, max, min;
        Console.Write("Digite o tamanho do vetor desejado: ");
        quantidadeVetor = Convert.ToInt32(Console.ReadLine());
        int[] meuVetor = new int[quantidadeVetor];
        for (i = 0; i < quantidadeVetor; i++)
        {
            meuVetor[i] = getVetor();
            Console.WriteLine($"O {i + 1}º elemento do vetor é {meuVetor[i]}");
        }
        max = maiorValor(meuVetor);
        min = menorValor(meuVetor, max);

        Console.WriteLine("O menor elemento do vetor é " + min);
        Console.WriteLine("O maior elemento do vetor é " + max);

    }
    static int getVetor()
    {
        Random numerosAleatorios = new Random();
        int retorno;
        retorno = numerosAleatorios.Next(0, 101);
        return retorno;
    }
    static int maiorValor(int[] meuVetorParam)
    {
        int max = 0;
        foreach (int e in meuVetorParam)
        {
            if (e > max)
                max = e;
        }
        return max;
    }
    static int menorValor(int[] meuVetorParam, int max)
    {
        foreach (int e in meuVetorParam)
        {
            if (e < max)
                max = e;
        }
        return max;
    }
}
