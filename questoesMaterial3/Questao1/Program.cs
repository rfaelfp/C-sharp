using System;
class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Digite o número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.Write($"O número {num} é par!");
    }
}
