using System;
class Program
{
    static void Main(string[] args)
    {
        int limInf, limSup, i, cont = 0;
        Console.Write("Informe o limite inferior: ");
        limInf = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o limite superior: ");
        limSup = Convert.ToInt32(Console.ReadLine());

        for (i = limInf; i <= limSup; i++)
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                cont++;
            }
        Console.WriteLine($"Entre o número {limInf} e {limSup} há {cont} números pares.");
    }
}