using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        result = Math.Pow(num1, num2);
        Console.WriteLine("O resultado é " + result);
    }
}