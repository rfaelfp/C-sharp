using System;
					
public class Program
{
	public static void Main()
	{
		int numero1, numero2, numero3, numero4, soma;
		
		Console.WriteLine("Programa que soma quatro números");
		
		Console.Write("Digite o primeiro número = ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(numero1);
		
		Console.Write("Digite o segundo número = ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(numero2);
		
		Console.Write("Digite o terceiro número = ");
		numero3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(numero3);
		
		Console.Write("Digite o quarto número = ");
		numero4 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(numero4);
		
		soma = numero1 + numero2 + numero3 + numero4;
		
		Console.WriteLine("Soma = " + soma);
	}


class Exercicio02 {
	public static void teste()
		{
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

}

teste()