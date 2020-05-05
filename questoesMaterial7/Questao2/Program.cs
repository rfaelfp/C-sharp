using System;
class Program
{
    static void Main(string[] args)
    {
        double[] vetor = new double[10];
        int i;
        double soma = 0, contImpar = 0, contMedia = 0, somaNeg = 0;
        for (i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite os valores do vetor: ");
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (i = 0; i < vetor.Length; i++)
        {
            if (Math.Abs(vetor[i]) % 2 == 1)
                contImpar++;
            if (vetor[i] > 0)
            {
                soma += vetor[i];
                contMedia++;
            }
            if (vetor[i] < 0)
                somaNeg += vetor[i];
        }


        Console.WriteLine("Quantidade de números impares " + contImpar);
        Console.Write("As posições dos números pares: ");
        for (i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
                Console.Write(i + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("A média aritimética dos números positivos " + soma / contMedia);
        Console.WriteLine("O quadrado da soma dos números negativos " + Math.Pow(Math.Abs(somaNeg), 2));

    }
}
