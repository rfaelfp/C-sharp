using System;

public class Program { 

    public static void Main() { 
    float nota1, nota2, nota3, mediaAritimetica;

    Console.WriteLine("Programa de média aritimética");

    Console.Write("Digite a primeira nota ");
    nota1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a segunda nota ");
    nota2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a terceira nota ");
    nota3 = Convert.ToInt32(Console.ReadLine());

    mediaAritimetica = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"A média aritimética é {mediaAritimetica.ToString("F2")}");
    }

}