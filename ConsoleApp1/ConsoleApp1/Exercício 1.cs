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
}