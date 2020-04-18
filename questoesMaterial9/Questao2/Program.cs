using System;
class Program
{
    static void Main(string[] args)
    {
        int primeiroNumero, segundoNumero;
        Console.Write("Digite o primeiro número: ");
        primeiroNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        maiorNumero(primeiroNumero, segundoNumero);
        numerosPares(primeiroNumero, segundoNumero);
    }
    static void maiorNumero(int primeiroNumeroSaida, int segundoNumeroSaida)
    {
        if (primeiroNumeroSaida > segundoNumeroSaida)
        {
            Console.WriteLine($"O {primeiroNumeroSaida} é o maior número digitado");
        }
        else
        {
            Console.WriteLine($"O {segundoNumeroSaida} é o maior número digitado");
        }
    }
    static void numerosPares(int primeiroNumeroSaida, int segundoNumeroSaida)
    {
        Console.Write("Os números pares no intervalo são: ");
        if (primeiroNumeroSaida > segundoNumeroSaida)
        {
            for (int i = segundoNumeroSaida; i <= primeiroNumeroSaida; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}