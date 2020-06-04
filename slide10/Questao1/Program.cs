using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        dobro(ref numero);
        Console.WriteLine("Resultado: " + numero);
    }
    static void dobro (ref int numero)
    {
        numero *= 2;
    }
}
