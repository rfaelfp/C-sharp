using System;

class Program
{
	static void Main(string[] args)
	{
		double custoTeatroTotal, precoConvite, qtdConvites, qtdLucro;
		Console.Write("Digite o custo do teatro: ");
		custoTeatroTotal = Convert.ToDouble(Console.ReadLine());
		Console.Write("Digite o preço do convite: ");
		precoConvite = Convert.ToDouble(Console.ReadLine());
		qtdConvites = custoTeatroTotal / precoConvite;
		qtdConvites = Math.Ceiling(qtdConvites);
		qtdLucro = Math.Ceiling((qtdConvites / 100) * 30 + qtdConvites);
		Console.WriteLine($"É necessário vender {qtdConvites} convites para pagar o custo do teatro.");
		Console.WriteLine($"Para que tenha o lucro de 30% é necessário vender {qtdLucro} convites.");
	}

}
