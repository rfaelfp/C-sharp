using System;
class Program
{
    static void Main(string[] args)
    {
        int numeroEntrada;
        Console.Write("Digite um número: ");
        numeroEntrada = Convert.ToInt32(Console.ReadLine());

        numeroParImpar(numeroEntrada);
        numerosImpares(numeroEntrada);
    }
    static void numeroParImpar(int numeroSaida)
    {
        if (numeroSaida % 2 == 0)
        {
            Console.WriteLine($"O número {numeroSaida} é par!");
        }
        else
        {
            Console.WriteLine($"O número {numeroSaida} é impar!");
        }
    }
    static void numerosImpares(int numeroSaida)
    {
        for (int i = 0; i <= numeroSaida; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
